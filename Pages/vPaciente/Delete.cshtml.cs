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

namespace WebAmb.Pages.vPaciente
{
    public class DeleteModel : PageModel
    {
        private readonly WebAmb.Data.ApplicationDbContext _context;

        public DeleteModel(WebAmb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Paciente Paciente { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Paciente = await _context.Paciente.FirstOrDefaultAsync(m => m.paciente_id == id);

            if (Paciente == null)
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

            Paciente = await _context.Paciente.FindAsync(id);

            if (Paciente != null)
            {
                _context.Paciente.Remove(Paciente);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
