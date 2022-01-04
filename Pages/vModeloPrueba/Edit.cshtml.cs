#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAmb.Data;
using WebAmb.Models;

namespace WebAmb.Pages.vModeloPrueba
{
    public class EditModel : PageModel
    {
        private readonly WebAmb.Data.ApplicationDbContext _context;

        public EditModel(WebAmb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ModeloPrueba ModeloPrueba { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ModeloPrueba = await _context.ModeloPrueba.FirstOrDefaultAsync(m => m.id == id);

            if (ModeloPrueba == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ModeloPrueba).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModeloPruebaExists(ModeloPrueba.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ModeloPruebaExists(int id)
        {
            return _context.ModeloPrueba.Any(e => e.id == id);
        }
    }
}
