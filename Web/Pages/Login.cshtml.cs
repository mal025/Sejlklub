using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lib.Model;
using Lib.Repo;
using Lib.Services;
using System.Diagnostics;

namespace Web.Pages
{
    public class LoginModel : PageModel
    {

        MemberService memberService = new MemberService(new MemberJSONRepo());

        [BindProperty]
        List<Member> members = memberService.GetAll();

        public IActionResult OnPost()
        {

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
        public void OnGet()
        {
        }
    }
}
