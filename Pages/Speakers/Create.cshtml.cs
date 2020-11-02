﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tech_Talks_Web_App.Business;
using Tech_Talks_Web_App.Models;

namespace Tech_Talks_Web_App.Pages.Speakers
{
    public class CreateModel : PageModel
    {
        private readonly Tech_Talks_Web_App.Models.Tech_Talks_Web_DataContext _context;

        public CreateModel(Tech_Talks_Web_App.Models.Tech_Talks_Web_DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Speaker Speaker { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Speaker.Add(Speaker);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
