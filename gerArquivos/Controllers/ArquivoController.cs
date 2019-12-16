using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using gerArquivos.Models;
using gerArquivos.Models.vo;
using System.IO;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace gerArquivos.Controllers
{    
    public class ArquivoController : Controller
    {
        repoArquivo repositorio = null;

        public IActionResult Index()
        {
           
                List<voArquivo> lista = null;

                try
                {
                    repositorio = new repoArquivo();

                    lista = repositorio.Lista();
                }
                catch (Exception ex)
                {
                    TempData["mensagemErro"] = "Erros " + ex.Message;
                }
                finally
                {
                    repositorio.Dispose();
                }

                return View(lista);

        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile NomeArquivo)
        {
            voArquivo voArq = new voArquivo();           

            try
            {
                if (NomeArquivo == null || NomeArquivo.Length == 0)
                    return Content("file not selected");

                string caminhoPasta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\upload");

                if (!Directory.Exists(caminhoPasta))
                {
                    Directory.CreateDirectory(caminhoPasta);
                }

                var path = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot\\upload",
                            NomeArquivo.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await NomeArquivo.CopyToAsync(stream);
                }


                repositorio = new repoArquivo();
                voArq.Nome = NomeArquivo.FileName;

                repositorio.addArquivo(voArq);

                TempData["mensagem"] = "Arquivo Salvo com sucesso";
            }
            catch (Exception ex)
            {
                TempData["mensagem"] = "Erros encontrados";
                voArq.Erros.Add(ex.Message);
            }
            finally
            {
                repositorio.Dispose();
            }

            return View("AddARquivo", voArq);
        }      

        public IActionResult AddArquivo()
        {
            return View();
        }

        

    }
}