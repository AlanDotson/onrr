using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;

namespace QEP.ONRR.Web.Models
{
    public class IndexViewModel : BaseViewModel
    {

        public UserPrincipal CurrentUser { get; set; }

        public List<string> Roles { get; set; }
    }
}