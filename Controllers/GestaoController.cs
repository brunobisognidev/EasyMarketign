using Microsoft.AspNetCore.Mvc;
using System;

namespace easy.Controllers
{
  public class GestaoController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}