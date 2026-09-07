using Microsoft.AspNetCore.Mvc;
using ProjetoAgendamento.Models;
using System.Diagnostics;

namespace ProjetoAgendamento.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}
