using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EleWise.ELMA.SmartEngineIntegration.Managers
{
    public class TempFilesManager
    {
        public string SaveBytesAsTempFile(byte[] bytes, string name = null, string extension = null)
        {
            if (name == null)
            {
                name = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString();
            }

            if (extension == null)
            {
                extension = "txt";
            }

            var resultName = name + '.' + extension;
            File.WriteAllBytes(resultName, bytes);
            return resultName;
        }

        public byte[] ReadTempFileAsBytes(string fileName)
        {
            return File.ReadAllBytes(fileName);
        }
    }
}
