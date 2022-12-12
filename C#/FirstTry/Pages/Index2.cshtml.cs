using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstTry.Pages
{
    public class Index2Model : PageModel
    {
        public string Message { get; private set; } = "PageModel in c#";
        public void OnGet()
        {
            Message += $"Server time is : {DateTime.Now}";
        }
    }
}
