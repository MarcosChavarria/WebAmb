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
    public class IndexModel : PageModel
    {
        private readonly WebAmb.Data.ApplicationDbContext _context;

        public IndexModel(WebAmb.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ModeloPrueba> ModeloPrueba { get;set; }

        public async Task OnGetAsync()
        {
            ModeloPrueba = await _context.ModeloPrueba.ToListAsync();
        }
    }
}
