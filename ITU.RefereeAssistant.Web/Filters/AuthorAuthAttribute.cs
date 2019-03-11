using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITU.RefereeAssistant.Web.Filters
{
    public class AuthorAuthAttribute : FilterAttribute, IAuthorizationFilter
    {        
        public void OnAuthorization(AuthorizationContext authContext)
        {
            PermissionManager permissionManager = new PermissionManager();
            string action = authContext.ActionDescriptor.ActionName;
            string controller = authContext.ActionDescriptor.ControllerDescriptor.ControllerName;                       
            //var parameters = authContext.ActionDescriptor.GetParameters();
            var filePath = authContext.HttpContext.Request.FilePath.Split(new char[] { '/' });
            string Id = filePath[filePath.Length - 1];                        
            bool isUserAccess = false;
            switch (controller)
            {
                case "Round":
                    switch (action)
                    {
                        case "Details":
                            if (Id != "")
                            {
                                isUserAccess = permissionManager.ValidateAuthorRoute(Convert.ToInt64(Id));
                            }
                            else
                            { isUserAccess = true; }
                            break;
                    }
                    break;
            }

            if (!isUserAccess)
            {
                throw new UnauthorizedAccessException("Пользователю не разрешено использование данного действия");
            }
        }
    }
}