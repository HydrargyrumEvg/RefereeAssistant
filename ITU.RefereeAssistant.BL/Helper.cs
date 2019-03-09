using ITU.RefereeAssistant.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ITU.RefereeAssistant.BL
{
    public static class Helper
    {
        /// <summary>
        /// Загрузить типы турнирных систем из Dllек
        /// </summary>
        /// <param name="path">Путь до библиотек</param>
        /// <returns>Список операций</returns>
        public static List<ITournamentType> LoadTournamentTypes(string path = "")
        {
            var result = new List<ITournamentType>();            

            var currentDirectory = string.IsNullOrWhiteSpace(path) ? AppDomain.CurrentDomain.BaseDirectory + @"bin\" : path;

            var dlls = Directory.GetFiles(currentDirectory, "*.dll");

            foreach (var dll in dlls)
            {
                var assembly = Assembly.LoadFrom(dll);

                var types = assembly.GetTypes();

                foreach (var type in types)
                {
                    var interfaces = type.GetInterfaces();

                    if (interfaces.Any(inter => inter.Name == "ITournamentType"))
                    {
                        if (Activator.CreateInstance(type) is ITournamentType tournamentType)
                        {
                            result.Add(tournamentType);
                        }
                    }
                }
            }
            return result;
        }
    }
}