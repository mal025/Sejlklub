using Lib.Model;
using Lib.Repo;

using Lib.Services;
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




        }
    }
}
