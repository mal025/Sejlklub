using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lib.Model;
using Lib.Services;
using System.Diagnostics;

namespace Web.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string TestEmail { get; set; }
        [BindProperty]
        public string TestPassword { get; set; }
        [BindProperty]
        public bool LoggedIn { get; set; }
        [BindProperty]
        public bool EmailCorrect { get; set; } = true;
        [BindProperty]
        public bool PasswordCorrect { get; set; } = true;



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
                if (member.Email == TestEmail)
                {
                    if (member.Password == TestPassword) {
                        
                        Debug.WriteLine("Du er logget ind!!");
                        LoggedIn = true;
                        break; 
                    }
                    else 
                    {
                        Debug.WriteLine("Forkert kodeord, prøv igen");
                        PasswordCorrect = false;
                        break; 
                    }
                }
                if (n == members.Count) 
                {
                    Debug.WriteLine("Forkert Email");
                    EmailCorrect = false;

                }
            }
        }
        public void OnGet()
        {
        }
    }
}
