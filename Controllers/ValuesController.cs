using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoletoFacilSDK.Model.Entities;
using BoletoFacilSDK.Model.Response;
using Microsoft.AspNetCore.Mvc;

namespace TesteBoletoFacilSDK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public void GerarBoleto()
        {
            //Payer payer = new Payer();
            //payer.Name = "Pagador teste - SDK .NET";
            //payer.CpfCnpj = "11122233300";

            //Charge charge = new Charge();
            //charge.Description = "Cobrança teste gerada pelo SDK .NET";
            //charge.Amount = 176.45m;
            //charge.Payer = payer;
            
            //ChargeResponse response = boletoFacil.IssueCharge(charge);
            //foreach (Charge c in response.Data.Charges)
            //{
            //    Console.WriteLine(c);
            //}
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
