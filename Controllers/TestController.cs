using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EleWise.ELMA.SmartEngineIntegration.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("API/[controller]")]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public string GetAvailableDocumentTypes()
        {
            return Environment.CurrentDirectory;
        }
    }
}
