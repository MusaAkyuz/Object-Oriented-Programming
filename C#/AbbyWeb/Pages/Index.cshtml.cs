using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

        public string Message { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
        public void OnGet()
		{
			Message = "Get yapıldı.";
			Name = "Musa";
			Surname = "Akyuz";
		}

		public void OnPost()
		{
			Message = "Post yapıldı.";
		}
	}
}