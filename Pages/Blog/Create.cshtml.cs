﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RAZORWEB.Models;

namespace RAZORWEB.Pages.Blog
{
    public class CreateModel : PageModel
    {
        private readonly RAZORWEB.Models.MyBlogContext _context;

        public CreateModel(RAZORWEB.Models.MyBlogContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Article Article { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.articles == null || Article == null)
            {
                return Page();
            }

            _context.Add(Article);

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
