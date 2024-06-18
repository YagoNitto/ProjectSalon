using Microsoft.AspNetCore.Mvc;
using ProjectSalonV2.Data;
using ProjectSalonV2.Models;

namespace ProjectSalonV2.Controllers;
public class AgendamentoController(AppDbContext db) : Controller
{
    private readonly AppDbContext _db = db;

    public IActionResult Index()
    {
        IEnumerable<Agendamento> agendamentos = _db.Agendamentos;

        return View(agendamentos);
    }

    public IActionResult Agendar()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Editar(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        Agendamento agendamento = _db.Agendamentos.FirstOrDefault(x => x.Id == id);

        if (agendamento == null) 
        {
            return NotFound();
        }

        return View(agendamento);
    }

    [HttpPost]
    public IActionResult Agendar(Agendamento agendamentos)
    {
        if (ModelState.IsValid)
        {
            _db.Agendamentos.Add(agendamentos);
            _db.SaveChanges();

            return RedirectToAction("Confirmacao");
        }

        return View();
    }

    [HttpPost]
    public IActionResult Editar(Agendamento agendamento)
    {
        if (ModelState.IsValid)
        {
            _db.Agendamentos.Update(agendamento);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        return View(agendamento);
    }

    [HttpGet]
    public IActionResult Excluir(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        Agendamento agendamento = _db.Agendamentos.FirstOrDefault(x => x.Id == id);

        if (agendamento == null)
        {
            return NotFound();
        }

        return View(agendamento);
    }

    [HttpPost]
    public IActionResult Excluir(Agendamento agendamento)
    {
        if (agendamento == null)
        {
            return NotFound();
        }

        _db.Agendamentos.Remove(agendamento);
        _db.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Confirmacao()
    {
        return View(); 
    }
}
