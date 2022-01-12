using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EleWise.ELMA.SmartEngineIntegration.FileConverters
{
    public class PdfToImageConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pathToFile">путь к исходному файлу</param>
        /// <returns>возвращает путь к временному файлу с правильным форматом</returns>
        public string ConvertToJpg(string pathToFile)
        {
            string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".jpg";
            return pathToFile;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes">содержимое исходного файла</param>
        /// <returns>возвращает путь к временному файлу с правильным форматом</returns>
        public string ConvertToJpg(byte[] pdfBytes)
        {
            string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".jpg";
            var stream = new MemoryStream(pdfBytes);
            using (var document = PdfDocument.Load(stream))
            {
                byte[] bytes = null;
                for (int index = 0; index < document.PageCount; index++)
                {
                    var image = document.Render(index, 300, 300, PdfRenderFlags.CorrectFromDpi);
                    image.Save(fileName, ImageFormat.Jpeg);
                }
            }

            return fileName;
        }
    }
}
