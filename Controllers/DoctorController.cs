using HospitaAppointmentSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitaAppointmentSystem.Controllers
{
    public class DoctorController: Controller
    {
        private readonly DataContext _context;
        public DoctorController(DataContext context)
        {   
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Doctors.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Doctor model)
        {
            _context.Doctors.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
            
        }
    }
}