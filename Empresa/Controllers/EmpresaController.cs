using System;
using System.Configuration;
using System.Net.Http;
using CNPJ.Models.Empresa;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Projects.ViewModels;

namespace Projects.Controllers.Empresa
{
    public class EmpresaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult Detalhes()
        {
            return new PartialViewResult() { ViewName = "~/Empresa/_Detalhes", ViewData = ViewData };
        }

        [HttpPost]
        public ActionResult Buscar(string cnpj)
        {
            var CNPJ = cnpj.Replace(".", "").Replace("/", "").Replace("-", "");

            try
            {
                using (var client = new HttpClient())
                {
                    var apiUrl = string.Format("{0}/{1}", "https://www.receitaws.com.br/v1/cnpj", CNPJ);

                    var response = client.GetAsync(apiUrl).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var retorno = response.Content.ReadAsStringAsync().Result;

                        var jsonConvert = JsonConvert.DeserializeObject<EmpresaViewModel>(retorno);

                        return PartialView("Empresa/_Detalhes", jsonConvert);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }

        [HttpPost]
        public ActionResult Salvar(EmpresaViewModel vm)
        {
            return null;
        }
    }
}
