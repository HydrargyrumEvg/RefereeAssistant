using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.Web.Services;
using System.Web;

namespace ITU.RefereeAssistant.Web.Filters
{
    internal class PermissionManager
    {                
        public PermissionManager()
        {
            user = HttpContext.Current.User.Identity.Name;
        }               
        public string user { get; set; }
        public bool ValidateAuthorRoute(long routeId)
        {
            return new BaseService<Round>().Get(routeId).Tournament.Author == user;            
        }
    }
}