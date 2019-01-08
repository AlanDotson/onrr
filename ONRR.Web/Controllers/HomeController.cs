using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Web.Mvc;
using QEP.ONRR.Web.Models;

namespace QEP.ONRR.Web.Controllers
{
    public class HomeController : Controller
    {
        // Index
        // This decoration tells the action what AD group the user must be a member of to be allowed to run the action
        [AuthorizeAD(Groups = "QEP App Devs")]
        public ActionResult Index()
        {
            var vm = new IndexViewModel {Title = "Index Page"};

            var user = UserPrincipal.Current;
            var groups = GetGroups(user.SamAccountName);

            if (groups != null)
            {
                vm.Roles = new List<string>();
                foreach (var group in groups)
                {
                    vm.Roles.Add(group.Name);
                }
            }
            vm.CurrentUser = user;

            return View(vm);
        }

        private List<GroupPrincipal> GetGroups(string userName)
        {
            var result = new List<GroupPrincipal>();
            var ctx = GetContext();
            var user = UserPrincipal.FindByIdentity(ctx, IdentityType.SamAccountName, userName);

            if (user != null)
            {
                PrincipalSearchResult<Principal> groups = user.GetGroups();

                var iterGroup = groups.GetEnumerator();
                using (iterGroup)
                {
                    while (iterGroup.MoveNext())
                    {
                        try
                        {
                            Principal p = iterGroup.Current;
                            result.Add((GroupPrincipal) p);
                        }
                        catch (PrincipalOperationException)
                        {
                            continue;
                        }
                    }
                }
            }

            return result;
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
    }
}