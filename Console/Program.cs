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
 


            //bs.Add(boat1);
            //MemberService ms = new MemberService(new MemberJSONRepo());
            //Member member1 = new Member(18,"male","Joakim",16,"11111111","arbitrary@arbitrary.com");
            //ms.Add(member1);

            /*BlogService blogService = new BlogService(new BlogJSONRepository());
            blogService.Add(new Blog());*/

            testCLI();

            void testCLI()
            {
                Console.WriteLine("Hillerød Sejlklub test program. Hvad ville du teste");
                Console.WriteLine("1. Blog");
                Console.WriteLine("2. Både");
                Console.WriteLine("3. Booking");
                Console.WriteLine("4. Begivenheder");
                Console.WriteLine("5. Medlemmer");


            }



        }
    }
}
