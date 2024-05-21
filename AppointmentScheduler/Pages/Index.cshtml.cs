using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppointmentScheduler.Data;
using AppointmentScheduler.Models;

namespace AppointmentScheduler.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppointmentScheduler.Data.AppDbContext _context;

        public IndexModel(AppointmentScheduler.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Appointment> Appointment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Appointment = await _context.Appointments.ToListAsync();
        }
    }
}
