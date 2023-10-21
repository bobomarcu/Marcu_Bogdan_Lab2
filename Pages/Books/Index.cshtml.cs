using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Marcu_Bogdan_Lab2.Data;
using Marcu_Bogdan_Lab2.Models;

namespace Marcu_Bogdan_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Marcu_Bogdan_Lab2.Data.Marcu_Bogdan_Lab2Context _context;

        public IndexModel(Marcu_Bogdan_Lab2.Data.Marcu_Bogdan_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.Include(b => b.Publisher).Include(b=>b.Author).ToListAsync();
            }
        }
    }
}
