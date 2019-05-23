using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CAMP.BLL;
using CAMP.Model;

namespace CAMP_API.Controllers
{
    public class CampaignController : ApiController
    {
        CampaignManagerBase _campaingManagerBase = new CampaignManagerBase();

        // GET api/values
        public IEnumerable<Campaign> Get()
        {
            return _campaingManagerBase.GetAll();
        }

        [ResponseType(typeof(Campaign))]
        public Campaign GetCampaign(int id)
        {
            return _campaingManagerBase.GetById(id);
        }

        [HttpPost]
        public void PostCampaign(Campaign cm)
        {
            _campaingManagerBase.Add(cm);
        }

        [HttpPut]
        public void putCampaign(Campaign cm)
        {
            _campaingManagerBase.Update(cm);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _campaingManagerBase.Delete(id);
        }
    }
}
