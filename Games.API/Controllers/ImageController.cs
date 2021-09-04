using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Games.API.Controllers
{
    [Route("api/game")]
    public class ImageController : ControllerBase
    {
        public static IWebHostEnvironment _environment;

        public ImageController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpGet("img")]
        public string Index()
        {
            string texto = " Web API - ImagemController em execução : " + DateTime.Now.ToLongTimeString();
            texto += $"\n Ambiente :  {_environment.EnvironmentName}";
            return texto;
        }

        [HttpPost("upload")]
        public async Task<string> SendImageAsync([FromForm] IFormFile arquivo)
        {
            if (arquivo.Length > 0)
            {
                try
                {
                    if (!Directory.Exists(_environment.WebRootPath + "images\\"))
                        Directory.CreateDirectory(_environment.WebRootPath + "images\\");

                    using (FileStream file = System.IO.File.Create(_environment.WebRootPath + "images\\" + arquivo.FileName))
                    {
                        await arquivo.CopyToAsync(file);
                        file.Flush();
                        return "images\\" + arquivo.FileName;
                    }
                }
                catch (Exception ex)
                {

                    return ex.ToString();
                }
            }
            else
            {
                return "Ocorreu um erro";
            }
        }
    }
}
