#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAmb.Data;
using WebAmb.Models;

namespace WebAmb.Pages.vModeloPrueba
{
    public class DeleteModel : PageModel
    {
        private readonly WebAmb.Data.ApplicationDbContext _context;

        public DeleteModel(WebAmb.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ModeloPrueba = await _context.ModeloPrueba.FindAsync(id);

            if (ModeloPrueba != null)
            {
                _context.ModeloPrueba.Remove(ModeloPrueba);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
