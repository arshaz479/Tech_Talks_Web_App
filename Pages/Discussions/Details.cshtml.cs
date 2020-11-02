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
    public class DetailsModel : PageModel
    {
        private readonly Tech_Talks_Web_App.Models.Tech_Talks_Web_DataContext _context;

        public DetailsModel(Tech_Talks_Web_App.Models.Tech_Talks_Web_DataContext context)
        {
            _context = context;
        }

        public Discussion Discussion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Discussion = await _context.Discussion.FirstOrDefaultAsync(m => m.Id == id);

            if (Discussion == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
