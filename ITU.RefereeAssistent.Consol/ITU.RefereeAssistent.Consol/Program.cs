using ITU.RefereeAssistant.BL;
using ITU.RefereeAssistant.Domain;
using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.Domain.TourType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU.RefereeAssistent.Consol
{
    class Program        
    {        
        static void Main(string[] args)
        {
            List<ITournamentType> tourTypes = new List<ITournamentType>()
            {
                new OlympicTourType()
            };
            string playerCntStr;
            int playerCnt;
            string playerName;
            Rating[] ratings;
            string tourTypeStr;
            int tourType;
            string entryModeStr;
            Boolean autoGenerate;
            Random random = new Random();            

            Console.WriteLine("Помошник спортивного судьи");
            Console.WriteLine("Введите систему организации турнира: ");
            for (int i = 0; i < tourTypes.Count; i++)
            {                
                Console.WriteLine(
                    $"{i + 1} - {tourTypes[i].Name}"
                    );
            }
            tourTypeStr = Console.ReadLine();
            tourType = Convert.ToInt32(tourTypeStr);
            
            do
            {
                Console.Write("Введите число участников: ");
                playerCntStr = Console.ReadLine();
                if (!int.TryParse(playerCntStr, out playerCnt))
                {
                    Console.WriteLine("Введено неверное значение");
                }
            }
            while (playerCnt == 0);
            ratings = new Rating[playerCnt];
            Console.Write("Укажите как будут введены участники  и результаты турнира (0 - вручную (по умолчанию), 1 - автоматически): ");
            entryModeStr = Console.ReadLine();
            switch (entryModeStr)
            {
                case "0":
                    autoGenerate = false;
                    break;
                case "1":
                    autoGenerate = true;
                    break;
                default:
                    Console.WriteLine("Введено неверная цифра, будет использован режим ввода по умолчанию");
                    autoGenerate = false;
                    break;
            }
            for (int i = 0; i < playerCnt; i++)
            {
                if (!autoGenerate)
                {
                    playerName = "";
                    do
                    {
                        Console.Write(String.Format("Ведите название команды {0}: ", i + 1));
                        playerName = Console.ReadLine();
                    }
                    while (playerName == "");
                }
                else
                {
                    playerName = String.Format("Player {0}", i + 1);
                }
                ratings[i] = new Rating(new Player() { Name = playerName });
            }            
            var ts = new TournamentService();
            var tour = ts.Create(ratings, tourTypes[tourType - 1]);
            var round = ts.GenerateRound(tour);
            
            do
            {
                foreach (var item in round.Matches)
                {
                    Console.WriteLine(item.ToString());
                }
                if (!autoGenerate)
                {
                    Console.WriteLine("Введите результаты раунда: ");
                    Console.WriteLine("1 - победа первого, 2 - ничья, 3 - победа второго");
                }
                else
                {
                    Console.WriteLine("Результаты раунда:");
                }
                foreach (var match in round.Matches)
                {
                    Console.WriteLine(match.ToString());
                    string result;
                    if (!autoGenerate)
                    {
                        result = Console.ReadLine();
                    }
                    else
                    {                        
                        result = Convert.ToString(random.Next(1, 4));
                        Console.WriteLine(result);
                    }
                    if (result == "1")
                    {
                        match.Ratings[0].Score = 3;
                    }
                    else if (result == "2")
                    {
                        match.Ratings[0].Score = 1;
                        match.Ratings[1].Score = 1;
                    }
                    else if (result == "3")
                    {
                        match.Ratings[1].Score = 3;
                    }
                }
                round = ts.GenerateRound(tour);
                if (round != null)
                {
                    Console.WriteLine("Следующий раунд: ");
                }                
            }
            while (round != null);
            Console.WriteLine("Турнир завершен");
            Console.ReadKey();
        }
    }
}
