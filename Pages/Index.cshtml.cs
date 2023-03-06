using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorBindProperties.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public User NewUser { get; set; }

        //public string? FirstName { get; set; }
        //public string? LastName { get; set; }
        //public int Age { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {

        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
        }
    }
}