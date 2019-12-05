using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageLesson.DataAccess;
using RazorPageLesson.Models;

namespace RazorPageLesson.Pages.People
{
    public class IndexModel : PageModel
    {
        private readonly PersonsContext _context;

        public IndexModel(PersonsContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.People.ToListAsync();
        }
    }
}
