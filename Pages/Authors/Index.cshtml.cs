﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moldovan_Paula_Lab2.Data;
using Moldovan_Paula_Lab2.Models;

namespace Moldovan_Paula_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Moldovan_Paula_Lab2.Data.Moldovan_Paula_Lab2Context _context;

        public IndexModel(Moldovan_Paula_Lab2.Data.Moldovan_Paula_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
