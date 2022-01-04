﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAmb.Data;
using WebAmb.Models;

namespace WebAmb.Pages.vModeloPrueba
{
    public class CreateModel : PageModel
    {
        private readonly WebAmb.Data.ApplicationDbContext _context;

        public CreateModel(WebAmb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ModeloPrueba ModeloPrueba { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ModeloPrueba.Add(ModeloPrueba);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
