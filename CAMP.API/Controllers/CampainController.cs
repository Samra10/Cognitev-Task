using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CAMP.Model;
using CAMP.BLL;
using CAMP.Model;

namespace CAMP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampainController : ControllerBase
    {
        CampaigntManagerBase _campaignDataService = new CampaigntManagerBase();
        
        // GET: api/Campain
        [HttpGet]
        public IEnumerable<Campaign> Get()
        {
            return _campaignDataService.GetAll();
        }

        // GET: api/Campain/5
        [HttpGet("{id}", Name = "Get")]
        public Campaign Get(int id)
        {
            return _campaignDataService.GetById(id);
        }

        // POST: api/Campain
        [HttpPost]
        public void PostCampaign([FromBody]Campaign cm)
        {
            _campaignDataService.Add(cm);
        }

        // PUT: api/Campain/5
        [HttpPut("{id}")]
        public void putCampaign(Campaign cm)
        {
            _campaignDataService.Update(cm);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _campaignDataService.Delete(id);
        }
    }
}
