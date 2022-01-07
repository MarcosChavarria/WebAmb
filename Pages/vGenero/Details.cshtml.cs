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

namespace WebAmb.Pages.vGenero
{
    public class DetailsModel : PageModel
    {
        private readonly WebAmb.Data.ApplicationDbContext _context;

        public DetailsModel(WebAmb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Genero Genero { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Genero = await _context.Genero.FirstOrDefaultAsync(m => m.genero_id == id);

            if (Genero == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
