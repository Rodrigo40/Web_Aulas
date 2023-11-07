using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Web_Aulas.Controllers
{
    public class UsuariosController : Controller
    {
        // Passando dados via URL
        public IActionResult Index(int id)
        {
            #region View Index
            string t2 = string.Format("São: {0}", DateTime.Now.ToLongTimeString());
            DateTime dia = DateTime.Now;
            CultureInfo idioma = new CultureInfo("en-GB");
            for (int d = 1; d <= 7; d++)
            {
                t2 = $"Dia: {dia.ToString("D", idioma)} - Hora: {dia.ToString("hh:m:ss", idioma)}";
            }
            dynamic texto = DateTime.Now;
            // Interpolação

            ViewData["id"] = id;
            ViewBag.teste = t2;


            if (id != 10)
            {
                return View("Error");
            }
            return View();
            #endregion
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
