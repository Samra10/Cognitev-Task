using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CAMP.BLL.Common;
using CAMP.Model;
using CAMP.DAL;

namespace CAMP.BLL
{
    public class CampaignManagerBase : ManagerBase<Campaign>
    {
        private CampaignDataService _campantDataService;

        public CampaignManagerBase()
        {
            InstaScalerEntities entities = new InstaScalerEntities();
            _campantDataService = new CampaignDataService(entities);
        }
        public CampaignManagerBase(InstaScalerEntities entities) : base(entities)
        {
            _campantDataService = new CampaignDataService(entities);
        }

        /// <summary>
    	/// Gets the specified entity by ID.
    	/// </summary>
    	/// <param name="id">The Campapaign ID.</param>
    	public override Campaign GetById(int id)
        {
            return _campantDataService.GetById(id);
        }

        /// <summary>
    	/// Gets All.
    	/// </summary>
    	public override List<Campaign> GetAll()
        {
            return _campantDataService.GetAll();
        }

        /// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="cm">The Campaign entity.</param>
    	public override Campaign Add(Campaign cm)
        {

            _campantDataService.Add(cm);
            return cm;
        }

        /// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="cm">The Campaign entity.</param>
    	public override void Delete(Campaign cm)
        {
            _campantDataService.Delete(cm);
        }

        /// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The Campaign Id.</param>
    	public override void Delete(int id)
        {
            _campantDataService.Delete(id);
        }

        /// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="pr">The product entity.</param>
    	public override Campaign Update(Campaign cm)
        {
            _campantDataService.Update(cm);
            return cm;
        }
    }
}