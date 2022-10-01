using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OurFirstApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string? Message { get; set; }
        


        public void OnGet()
        {
            Message = $"Hello World {DateTime.Now.ToLongTimeString()}";
        }
    }
}