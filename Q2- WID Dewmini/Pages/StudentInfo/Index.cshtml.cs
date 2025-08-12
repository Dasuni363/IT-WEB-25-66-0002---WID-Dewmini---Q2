using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Q2__WID_Dewmini.Data;
using Q2__WID_Dewmini.Models;

namespace Q2__WID_Dewmini.Pages.StudentInfo
{
    public class IndexModel : PageModel
    {
        private readonly Q2__WID_Dewmini.Data.Q2__WID_DewminiContext _context;

        public IndexModel(Q2__WID_Dewmini.Data.Q2__WID_DewminiContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
