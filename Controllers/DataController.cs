using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlockApi.Model;
using Newtonsoft.Json;


namespace BlockApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<BlockResult>> Get()
        {
            return GetData().ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<BlockResult>> Get(string id)
        {
            return GetData().Where(x => x.txHash == id).ToList();
        }

        public IEnumerable<BlockResult> GetData()
        {        
            IEnumerable<BlockResult> result;

            string rawData = System.IO.File.ReadAllText(@"Data\data.json");

            BlockData data = JsonConvert.DeserializeObject<BlockData>(rawData);                           
            
            result = data.result.Select(x => new BlockResult
                {
                    txHash = x.transactionHash.ToString(),
                    blockNumber = Convert.ToInt64(x.blockNumber, 16),
                    gasPrice = Convert.ToInt64(x.gasPrice, 16),
                    gasUsed = Convert.ToInt64(x.gasUsed, 16),
                    timestamp = new DateTime(1970, 1, 1).AddSeconds(Convert.ToInt64(x.timeStamp, 16)),
                }
            );
            
            return result;
        }
    }
}
