using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lib.Model;
using Lib.Services;
using System.Diagnostics;

namespace Web.Pages
{
    public class LoginModel : PageModel
    {
        public string testemail { get; set; }
        public string testkode { get; set; }
        [BindProperty]
        public bool LoggedIn { get; set; }

        private MemberService _memberService;

        public LoginModel(MemberService ms)
        {
            _memberService = ms;

        }


        public void OnPost()
        {
            List<Member> members = _memberService.GetAll();
            int n = 0;
            foreach (Member member in members)
            {
                n++;
                if (member.Email == testemail)
                {
                    if (member.Password == testkode) {
                        
                        Debug.WriteLine("Du er logget ind!!");
                        LoggedIn = true;
                        break; 
                    }
                    else { Debug.WriteLine("Forkert kodeord, prøv igen"); break; }
                }
                if (n == members.Count) { Debug.WriteLine("Forkert Email"); }
            }
        }
        public void OnGet()
        {
        }
    }
}
