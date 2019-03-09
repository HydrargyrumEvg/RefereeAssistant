using ITU.RefereeAssistant.Domain;
using ITU.RefereeAssistant.Web.Services;
using ITU.RefereeAssistant.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ITU.RefereeAssistant.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //сервис для хранения новых типов в БД
            var TourTypeService = new BaseService<TournamentType>();

            var dbTourTypes = TourTypeService.GetAll().Select(item => item.TypeName);
            //получаем список типов системы
            var tourTypes = Helper.LoadTournamentTypes(AppDomain.CurrentDomain.BaseDirectory + @"bin\");
            foreach (var tourType in tourTypes)
            {
                var typeName = tourType.GetType().FullName;
                //если в БД еще нет такого типа
                if (!dbTourTypes.Contains(typeName))
                {
                    //создаем новую сущность
                    var newTourType = new TournamentType()
                    {
                        Name = tourType.Name,
                        TypeName = typeName
                    };
                    TourTypeService.Save(newTourType);
                }
            }
        }
    }
}
