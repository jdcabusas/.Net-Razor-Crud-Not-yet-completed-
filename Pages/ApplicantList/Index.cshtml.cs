using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Applicant_List.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Applicant_List
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Applicant> Applicants { get; set; }


        public async Task OnGet()
        {
            Applicants = await _db.Applicant.ToListAsync();
        }
    }
}