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
    public class DetailsModel : PageModel
    {
        private readonly WebAmb.Data.ApplicationDbContext _context;

        public DetailsModel(WebAmb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
