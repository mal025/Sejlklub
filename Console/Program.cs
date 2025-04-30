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
            Console.WriteLine("Hello, World!");
            //Booking booking = new Booking();

            BoatService bs = new BoatService(new BoatJSONRepository());
            Boat boat1 = new Boat();


            //bs.Add(boat1);
            //MemberService ms = new MemberService(new MemberJSONRepo());
            //Member member1 = new Member(18,"male","Joakim",16,"11111111","arbitrary@arbitrary.com");
            //ms.Add(member1);

            BlogService blogService = new BlogService(new BlogJSONRepository());
            blogService.Add(new Blog("string title"));



        }
    }
}
