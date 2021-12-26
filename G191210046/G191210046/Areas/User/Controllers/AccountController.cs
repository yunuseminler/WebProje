using G191210046.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G191210046.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var user = HttpContext.User.Identity.Name;
            var User = _context.ApplicationUser.Where(x => x.UserName == user).ToList();
            return View(User);
        }
    }
}
