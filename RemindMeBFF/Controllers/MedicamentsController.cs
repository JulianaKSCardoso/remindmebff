using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RemindMeBFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemindeMeBFF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicamentsController : ControllerBase
    {

        /*
          http://localhost:3333/medicaments_frequencies
          http://localhost:3333/medicaments_type
          http://localhost:3333/medicaments
         */
        [HttpGet]
        [Route("medicaments_frequencies")]
        public object GetMedicamentsFrequencies()
        {
            var retorno = JsonConvert.DeserializeObject<List<MedicamentFrequence>>(Constants.medicaments_frequencies);
            return retorno;
        }

        [HttpGet]
        [Route("medicaments_type")]
        public object GetMedicamentsType()
        {
            var retorno = JsonConvert.DeserializeObject<List<MedicamentType>>(Constants.medicaments_type);
            return retorno;
        }

        [HttpGet]
        [Route("medicaments")]
        public object GetMedicaments()
        {
            var retorno = JsonConvert.DeserializeObject<List<Medicament>>(Constants.medicaments);
            return retorno;
        }
    }
}
