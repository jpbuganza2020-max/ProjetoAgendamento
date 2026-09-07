using Microsoft.AspNetCore.Mvc;
using ProjetoAgendamento.Data;
using ProjetoAgendamento.Models;

namespace ProjetoAgendamento.Controllers;

public class PacientesController : Controller
{
    private readonly AppDbContext _context;

    public PacientesController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        List<Paciente> pacientes = _context.Pacientes.ToList();
        return View(pacientes);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Paciente paciente)
    {
        if (!ModelState.IsValid)
        {
            return View(paciente);
        }

        _context.Pacientes.Add(paciente);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        Paciente? paciente = _context.Pacientes.Find(id);

        if (paciente == null)
        {
            return RedirectToAction(nameof(Index));
        }

        return View(paciente);
    }

    [HttpPost]
    public IActionResult Edit(int id, Paciente paciente)
    {
        if (id != paciente.Id)
        {
            return RedirectToAction(nameof(Index));
        }

        if (!ModelState.IsValid)
        {
            return View(paciente);
        }

        _context.Pacientes.Update(paciente);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        Paciente? paciente = _context.Pacientes.Find(id);

        if (paciente == null)
        {
            return RedirectToAction(nameof(Index));
        }

        return View(paciente);
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        Paciente? paciente = _context.Pacientes.Find(id);

        if (paciente != null)
        {
            _context.Pacientes.Remove(paciente);
            _context.SaveChanges();
        }

        return RedirectToAction(nameof(Index));
    }
}
