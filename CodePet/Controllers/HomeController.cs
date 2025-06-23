using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers;

public class HomeController : Controller {
    private static CodePet _pet = new CodePet();

    public IActionResult Index() {
        return View(_pet);
    }

    [HttpPost]
    public IActionResult Fuettern() {
        if (_pet.Hunger > 0) _pet.Hunger--;
        return RedirectToAction("Index");
    }
}