using EleWise.ELMA.SmartEngineIntegration.FileConverters;
using EleWise.ELMA.SmartEngineIntegration.Managers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace EleWise.ELMA.SmartEngineIntegration.Controllers
{

    [Produces("application/json")]
    [ApiController]
    [Route("API/[controller]")]
    public class RecognitionController : ControllerBase
    {
        /// <summary>
        /// Распознавание изображения
        /// </summary>
        /// <param name="type">Тип документа</param>
        /// <param name="urls">Ссылки на файлы</param>
        /// <returns></returns>
        [HttpPost]
        public List<Dictionary<string, string>> RecognizeImagesByUrl(string type, string[] urls)
        {
            List<Dictionary<string, string>> res = new List<Dictionary<string, string>>();
            using (var client = new WebClient())
            {
                List<string> list = new List<string>();
                foreach (var link in urls)
                {
                    var test = client.DownloadData(link);
                    string s = Convert.ToBase64String(test);
                    list.Add(s);
                }

                res = RecognitionManager.Instance().Recognition(list, null);
            }
            return res;
        }
        
        [HttpPost("RecognizeImageByUrl")]
        public List<Dictionary<string, string>> RecognizeImageByUrl(string type, string url)
        {
            var link = HttpUtility.UrlDecode(url);
            List<Dictionary<string, string>> res = new List<Dictionary<string, string>>();
            using (var client = new WebClient())
            {
                List<string> list = new List<string>();
                var bytes = client.DownloadData(link); 
                var contentType = client.ResponseHeaders["Content-Type"];
                if (contentType != null && contentType.ToLower() == "application/pdf")
                {
                    var converter = new PdfToImageConverter();
                    var tempManager = new TempFilesManager();
                    var resultPath = converter.ConvertToJpg(bytes);
                    var imageBytes = tempManager.ReadTempFileAsBytes(resultPath);
                    string s = Convert.ToBase64String(imageBytes);
                    list.Add(s);
                }
                else
                {
                    string s = Convert.ToBase64String(bytes);
                    list.Add(s);
                }

                res = RecognitionManager.Instance().Recognition(list, type);
            }
            return res;
        }
    }
}
