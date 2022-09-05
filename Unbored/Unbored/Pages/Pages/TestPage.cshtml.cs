using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Unbored.Pages
{
    public class TestPageModel : PageModel
    {
        private readonly ILogger<TestPageModel> _logger;

        public TestPageModel(ILogger<TestPageModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
