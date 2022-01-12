using EleWise.ELMA.SmartEngineIntegration.Managers;
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
    public class DcoumentTypeController : ControllerBase
    {
        [HttpGet]
        public List<List<string>> GetAvailableDocumentTypes()
        {
            return RecognitionManager.Instance().GetSupportedDocumentTypes();
        }
    }
}
