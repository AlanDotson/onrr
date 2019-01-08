using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Web.Mvc;

namespace QEP.ONRR.Web.Controllers
{
    public class AuthorizeADAttribute : AuthorizeAttribute
    {
        private static readonly MemoryCache _cache = MemoryCache.Default;

        public string Groups { get; set; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            /* Return true immediately if the authorization is not 
            locked down to any particular AD group */
            if (string.IsNullOrEmpty(Groups))
            {
                return true;
            }

            var user = UserPrincipal.Current;
            var groups = GetGroups(user.SamAccountName);

            if (groups != null)
            {
                if (groups.Any(@group => string.Equals(@group.Name, Groups, StringComparison.CurrentCultureIgnoreCase)))
                {
                    return true;
                }
            }

            return false;
        }

        private List<GroupPrincipal> GetGroups(string userName)
        {
            // Check the cache first
            var cacheName = "GetGroups" + userName;
            if (_cache.Contains(cacheName))
            {
                return _cache.Get(cacheName) as List<GroupPrincipal>;
            }
            else
            {
                var result = new List<GroupPrincipal>();
                var ctx = GetContext();
                var user = UserPrincipal.FindByIdentity(ctx, IdentityType.SamAccountName, userName);

                if (user != null)
                {
                    var groups = user.GetGroups();
                    var iterGroup = groups.GetEnumerator();

                    using (iterGroup)
                    {
                        while (iterGroup.MoveNext())
                        {
                            try
                            {
                                var p = iterGroup.Current;
                                result.Add((GroupPrincipal) p);
                            }
                            catch (PrincipalOperationException)
                            {
                                continue;
                            }
                        }
                    }

                    // Cache for one day
                    var cacheItemPolicy = new CacheItemPolicy {AbsoluteExpiration = DateTime.Now.AddDays(1)};
                    _cache.Add(cacheName, result, cacheItemPolicy);
                }

                return result;
            }
        }

        private PrincipalContext GetContext()
        {
            const string connectionString = "LDAP://qep.local/ou=qep,dc=qep,dc=local";

            var uri = new Uri(connectionString);
            var host = uri.Host;
            var container = uri.Segments.Length >= 1 ? uri.Segments[1] : "";

            // Create context to connect to AD
            var princContext = new PrincipalContext(ContextType.Domain, host, container);

            return princContext;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            var result = new ViewResult
            {
                ViewName = "NotAuthorized",
                MasterName = "_Layout"
            };
            filterContext.Result = result;
        }
    }
}