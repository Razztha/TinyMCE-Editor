using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HtmlEditor.Pages
{
    public class IndexModel : PageModel
    {
        public string PersonalDetails { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
        
        public void OnPostSubmit(string personalDetails)
        {
            this.PersonalDetails = personalDetails;
        }
    }
}