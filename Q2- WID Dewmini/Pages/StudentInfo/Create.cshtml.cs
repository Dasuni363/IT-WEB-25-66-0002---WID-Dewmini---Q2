using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Q2__WID_Dewmini.Data;
using Q2__WID_Dewmini.Models;

namespace Q2__WID_Dewmini.Pages.StudentInfo
{
    public class CreateModel : PageModel
    {
        private readonly Q2__WID_Dewmini.Data.Q2__WID_DewminiContext _context;

        public CreateModel(Q2__WID_Dewmini.Data.Q2__WID_DewminiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
