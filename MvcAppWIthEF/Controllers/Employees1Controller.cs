using Microsoft.AspNetCore.Mvc;
using MvcAppWIthEF.Context;
using MvcAppWIthEF.Models;

namespace MvcAppWIthEF.Controllers
{
    public class Employees1Controller : Controller
    {
        EmpDbContext _context;
        // DI
        public Employees1Controller(EmpDbContext context)
        {
            _context = context;
        }
        // there is a concept of DI
        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.Employees.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(_context.Employees.FirstOrDefault(

                c => c.Id == id));
        }

        public IActionResult Edit(int id)
        {
            return View(_context.Employees.FirstOrDefault(

                c => c.Id == id));

        }
        [HttpPost]
        public IActionResult Edit(int id, Employee employee)
        {
            foreach(var item in _context.Employees)
            {
                if(item.Id == id)
                {
                    item.Dept = employee.Dept;
                    item.Exp = employee.Exp;
                    break;
                }
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return View(_context.Employees.FirstOrDefault(

                c => c.Id == id));

        }
        [HttpPost]
        public IActionResult Delete(int id, Employee employee)
        {
            foreach (var item in _context.Employees)
            {
                if (item.Id == id)
                {
                    _context.Employees.Remove(item);
                    break;
                }
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
