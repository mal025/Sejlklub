using System.Security.Cryptography.X509Certificates;
using Lib.Model;
using Lib.Repo;

using Lib.Services;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ProgramConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Run all services
            BlogService blogService = new BlogService(new BlogJSONRepository());
            BookingService bookingService = new BookingService(new BookingJSONRepository());
            BoatService boatService = new BoatService(new BoatJSONRepository());
            EventService eventService = new EventService(new EventJSONRepository());
            MemberService memberService = new MemberService(new MemberJSONRepo());
            List<Member> members = memberService.GetAll();
            testCLI();
            void testCLI()
            {
                Console.WriteLine("Hillerød Sejlklub test program. Hvad ville du teste?");
                Console.WriteLine("1. Blog");
                Console.WriteLine("2. Både");
                Console.WriteLine("3. Booking");
                Console.WriteLine("4. Begivenheder");
                Console.WriteLine("5. Medlemmer");
                Console.WriteLine("6. login");
                Console.Write("Indsæt dit valg: ");
                int choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hvad ville du teste med Blog?");
                        break;
                    case 2:
                        Console.WriteLine("Hvad ville du teste med Både?");
                        break;
                    case 3:
                        Booking(boatService, bookingService);
                        break;
                    case 4:
                        Console.WriteLine("Hvad ville du teste med Begivenheder?");
                        break;
                    case 5:
                        Console.WriteLine("Hvad ville du teste med Medlemmer?");
                        break;
                    case 6:
                        Console.WriteLine("Indtast venligst Email til brugeren du vil teste");
                        string testemail = Console.ReadLine();
                        Console.WriteLine("Indtast Venligst Kodeordet til brugen");
                        string testkode = Console.ReadLine();
                        int n = 0;
                        foreach (var member in members)
                        {
                            n++;
                            if (member.Email == testemail)
                            {
                                if (member.Password == testkode) { Console.WriteLine("Du er logget ind!!"); break; }
                                else { Console.WriteLine("Forkert kodeord, prøv igen"); break; }
                            }
                            if (n== members.Count) { Console.WriteLine("Forkert Email"); }
                        }
                        break;
                    default:
                        Console.WriteLine("Indtast venligst et gyldigt tal!");
                        break;
                }

            }



        }

        public static void Booking(BoatService boatService, BookingService bookingService)
        {
            Console.WriteLine("Hvad ville du teste med Booking?");
            List<DateTime> list = new List<DateTime>();
            list.Add(DateTime.Now);
            list.Add(DateTime.Now);
            List<Boat> boats = boatService.GetAll();


            Console.WriteLine("Hvilken båd?");
            int boatChoice = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv en description af hvorfor");
            string description = Console.ReadLine();

            Console.WriteLine("Hvilken type? Altså personlig eller gruppe");
            string type = Console.ReadLine();

            Random random = new Random();


            Booking booking1 = new Booking(list, boats[boatChoice], description, type, random.Next(100000000));
            bookingService.Add(booking1);

        }
    }
}
