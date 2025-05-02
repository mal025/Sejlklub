using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
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
            List<Boat> boats = boatService.GetAll();

            testCLI();
            void testCLI()
            {
                Console.WriteLine("Hillerød Sejlklub test program. Hvad ville du teste?");
                Console.WriteLine("1. Blog");
                Console.WriteLine("2. Både (Ikke lavet endnu)");
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
                        TestBooking(boatService, bookingService, boats);
                        break;
                    case 4:
                        Console.WriteLine("Hvad ville du teste med Begivenheder?");
                        break;
                    case 5:
                        Console.WriteLine("Hvad ville du teste med Medlemmer?");
                        break;
                    case 6:
                        Login(members);
                        break;
                    default:
                        Console.WriteLine("Indtast venligst et gyldigt tal!");
                        break;
                }

            }



        }
        public static void Login(List<Member> members)
        {
            Console.WriteLine("Indtast venligst Email til brugeren du vil teste");
            string testemail = Console.ReadLine();
            Console.WriteLine("Indtast Venligst Kodeordet til brugen");
            string testkode = Console.ReadLine();
            int n = 0;
            foreach (Member member in members)
            {
                n++;
                if (member.Email == testemail)
                {
                    if (member.Password == testkode) { Console.WriteLine("Du er logget ind!!"); break; }
                    else { Console.WriteLine("Forkert kodeord, prøv igen"); break; }
                }
                if (n == members.Count) { Console.WriteLine("Forkert Email"); }
            }
        }

        public static void TestBooking(BoatService boatService, BookingService bookingService, List<Boat> boats)
        {
            Console.WriteLine("Hvad ville du teste med Booking?");
            Console.WriteLine("1. Se alle bookings");
            Console.WriteLine("2. Lave en ny booking");
            Console.WriteLine("3. Fjerne en booking via ID");
            Console.Write("Indsæt dit valg: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Dette er alle bookings");
                    foreach (Booking booking in bookingService.GetAll())
                    {
                        Console.WriteLine(JsonSerializer.Serialize(booking, new JsonSerializerOptions { WriteIndented = true }));
                    }
                    break;
                case 2:
                    Console.WriteLine("Opretter en booking");
                    // Takes input for the timeframe
                    Console.WriteLine("Indsæt start tidspunkt for i formatet yyyy-MM-dd HH:mm");
                    Console.Write("Indsæt dit valg: ");
                    DateTime startTime = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("Indsæt slut tidspunkt i formatet yyyy-MM-dd HH:mm");
                    Console.Write("Indsæt dit valg: ");
                    DateTime endTime = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    List<DateTime> timeFrame = new List<DateTime> { startTime, endTime };
                    // Takes input for the boat
                    Console.WriteLine("Indsæt hvilket ID på den båd du ville bruge");
                    Console.Write("Indsæt dit valg: ");
                    int idChoice = int.Parse(Console.ReadLine());
                    Boat boatChoice = boatService.GetByID(idChoice);
                    // Takes input for the description
                    Console.WriteLine("Hvad skal der ske i din booking?");
                    Console.Write("Skriv en beskrivelse af booking: ");
                    string description = Console.ReadLine();
                    Console.WriteLine();
                    // Takes input for the type of booking
                    Console.WriteLine("Hvilken type booking er det? medlem eller booking");
                    Console.Write("Indsæt (member/booking): ");
                    string type = Console.ReadLine();
                    Console.WriteLine();
                    // Creates an ID
                    Random random = new Random();
                    int bookingID = random.Next(0, 100000000);
                    // Creates the booking
                    Booking newBooking = new Booking(timeFrame, boatChoice, description, type, bookingID);
                    bookingService.Add(newBooking);
                    break;
                case 3:
                    Console.WriteLine("Indtast ID på booking du ville fjerne");

                    break;
                default:
                    break;
            }
        }
    }
}
