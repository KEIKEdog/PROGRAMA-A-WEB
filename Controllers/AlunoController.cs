using Microsoft.AspNetCore.Mvc;
public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Kaique";
        ViewBag.Cusro = "Tecnico Em Analise e Desenvolvimento de Sistemas";
        ViewBag.Semestre = "Primeiro Semestre";
        return View();
    }

     
}