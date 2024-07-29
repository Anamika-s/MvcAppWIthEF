using Microsoft.AspNetCore.Mvc;
using MvcAppWIthEF.Context;
using MvcAppWIthEF.Models;

namespace MvcAppWIthEF.Controllers
{
    public class UserController : Controller
    {
        EmpDbContext _context;
        public UserController(EmpDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }

        public IActionResult Create()
        {
            return View();
         }
        [HttpPost]
        public IActionResult Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        
    }
}
