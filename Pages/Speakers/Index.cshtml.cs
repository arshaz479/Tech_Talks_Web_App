using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tech_Talks_Web_App.Business;
using Tech_Talks_Web_App.Models;

namespace Tech_Talks_Web_App.Pages.Speakers
{
    public class IndexModel : PageModel
    {
        private readonly Tech_Talks_Web_App.Models.Tech_Talks_Web_DataContext _context;

        public IndexModel(Tech_Talks_Web_App.Models.Tech_Talks_Web_DataContext context)
        {
            _context = context;
        }

        public IList<Speaker> Speaker { get;set; }

        public async Task OnGetAsync()
        {
            Speaker = await (from speaker in _context.Speaker select speaker).ToListAsync();
        }
    }
}
