using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers;

public class HomeController : Controller
{
    // 'readonly' ist eine gute Praxis für Felder, die nur einmal zugewiesen werden.
    // 'new()' ist die kürzere Schreibweise für 'new CodePet()'.
    private static CodePet _pet = new CodePet();

    // Eine Methode mit nur einer Anweisung kann als "expression body" geschrieben werden.
    public IActionResult Index() => View(_pet);

    [HttpPost]
    public IActionResult Fuettern()
    {
        if (_pet.Hunger > 0) _pet.Hunger--; // Hunger um eins verringern
        return RedirectToAction("Index");
    }
}