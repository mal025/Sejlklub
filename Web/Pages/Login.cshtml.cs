using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lib.Model;
using Lib.Repo;
using Lib.Services;

namespace Web.Pages
{
    public class LoginModel : PageModel
    {
        MemberService memberService = new MemberService(new MemberJSONRepo());
        List<Member> members = memberService.GetAll();

        public void OnGet()
        {
        }
    }
}
