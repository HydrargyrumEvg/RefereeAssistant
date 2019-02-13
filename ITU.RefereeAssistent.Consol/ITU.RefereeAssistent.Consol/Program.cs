using ITU.RefereeAssistant.BL;
using ITU.RefereeAssistant.Domain.Models;
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
            string playerCntStr;
            int playerCnt;
            string playerName;
            Rating[] ratings;
            string tourTypeStr;
            TournamentType tourType;
            string entryModeStr;
            Boolean autoGeneratePlayers;

            Console.WriteLine("Помошник спортивного судьи");
            Console.Write("Введите систему организации турнира (0 - Олимпийская (по умолчанию), 1 - Шведская, 2 - Круговая): ");
            tourTypeStr = Console.ReadLine();
            switch (tourTypeStr)
            {
                case "0":
                    tourType = TournamentType.Olimpic;
                    break;
                case "1":
                    tourType = TournamentType.Swiss;
                    break;
                case "2":
                    tourType = TournamentType.Circle;
                    break;
                default:
                    Console.WriteLine("Введено неверная цифра, будет использована система по умолчанию");
                    tourType = TournamentType.Olimpic;
                    break;
            }
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
            Console.Write("Укажите как будут введены участники турнира (0 - вручную (по умолчанию), 1 - автоматически): ");
            entryModeStr = Console.ReadLine();
            switch (entryModeStr)
            {
                case "0":
                    autoGeneratePlayers = false;
                    break;
                case "1":
                    autoGeneratePlayers = true;
                    break;
                default:
                    Console.WriteLine("Введено неверная цифра, будет использован режим ввода по умолчанию");
                    autoGeneratePlayers = false;
                    break;
            }
            for (int i = 0; i < playerCnt; i++)
            {
                if (!autoGeneratePlayers)
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
                ratings[i] = new Rating()
                {
                    Player = new Player() { Name = playerName }
                };
            }            
            var ts = new TournamentService();
            var tour = ts.Create(ratings, tourType);
            var round = ts.GenerateRound(tour);
            foreach (var item in round.Matches)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
