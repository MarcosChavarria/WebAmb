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
    public class DetailsModel : PageModel
    {
        private readonly WebAmb.Data.ApplicationDbContext _context;

        public DetailsModel(WebAmb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
