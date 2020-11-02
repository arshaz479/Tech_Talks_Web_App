using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tech_Talks_Web_App.Business;
using Tech_Talks_Web_App.Models;

namespace Tech_Talks_Web_App.Pages.Discussions
{
    public class IndexModel : PageModel
    {
        private readonly Tech_Talks_Web_App.Models.Tech_Talks_Web_DataContext _context;

        public IndexModel(Tech_Talks_Web_App.Models.Tech_Talks_Web_DataContext context)
        {
            _context = context;
        }

        public IList<Discussion> Discussion { get;set; }

        public async Task OnGetAsync()
        {
            Discussion = await (from discussion in _context.Discussion select discussion).ToListAsync();
        }
    }
}
