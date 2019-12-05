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
    public class DetailsModel : PageModel
    {
        private readonly RazorPageLesson.DataAccess.PersonsContext _context;

        public DetailsModel(RazorPageLesson.DataAccess.PersonsContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.People.FirstOrDefaultAsync(m => m.Id == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
