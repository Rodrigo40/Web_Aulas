using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using Web_Aulas.Models;

namespace Web_Aulas.Controllers
{
    public class UsuariosController : Controller
    {
        // Passando dados via URL
        public IActionResult Index(int id)
        {
            #region View Index
            //string t2 = string.Format("São: {0}", DateTime.Now.ToLongTimeString());
            //DateTime dia = DateTime.Now;
            //CultureInfo idioma = new CultureInfo("en-GB");
            //for (int d = 1; d <= 7; d++)
            //{
            //    t2 = $"Dia: {dia.ToString("D", idioma)} - Hora: {dia.ToString("hh:m:ss", idioma)}";
            //}
            //dynamic texto = DateTime.Now;
            // Interpolação

            ViewData["id"] = id;
            //ViewBag.teste = t2;
            Response.Headers.Add("Refresh", "5");
            if (id == 1)
            {

                //int[] numeros = new int[5];
                List<int> numeros = new List<int>();
                numeros.Add(1);
                numeros.Add(2);
                numeros.Add(3);
                numeros.Add(4);
                for (int i = 0; i < numeros.Count; i++)
                {
                    numeros[i] = i * 5;
                }
                foreach (var item in numeros)
                {
                    ViewData["item"] = item;
                }
                ViewBag.res = Soma2Numeros(100, 200);
                Multiplica2Numeros();
                Pessoa p = new Pessoa();
                //ViewData["id"] = p.Id;
                //ViewData["nome"] = p.Nome;
                //ViewData["sobrenome"] = p.SobreNome;
                //Response.WriteAsync("<script>alert('Ola, voce não deveria estar aqui!')</script>");
                return View("Error", p);
            }
            return View();
            #endregion
        }
        public int Soma2Numeros(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        private void Multiplica2Numeros()
        {
            decimal n1, n2, res;
            n1 = 100;
            n2 = 200;
            res = n1 * n2;
            ViewBag.soma = res;
        }
        public IActionResult Error()
        {
            return View();
        }
    }

}
