using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace LanchesMac.Controllers;

public class LancheController : Controller
{
    private readonly ILancheRepository _lancheRepository;

    public LancheController(ILancheRepository lancheRepository)
    {
        _lancheRepository = lancheRepository;
    }

    public IActionResult List()
    {
        var lanches = _lancheRepository.Lanches;

        ViewBag.titulo = "Todos os lanches";
        ViewBag.totalLabel = "Total de lanches :";
        ViewBag.total = lanches.Count();
        ViewBag.data = DateTime.Now;
        return View(lanches);
    }
}
