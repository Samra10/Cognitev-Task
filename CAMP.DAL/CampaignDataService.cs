using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CAMP.DAL.Common;
using CAMP.Model;

namespace CAMP.DAL
{
    public class CampaignDataService : DataServiceBase<Campaign>
    {
        public CampaignDataService(InstaScalerEntities dataContext) : base(dataContext)
        {
            this.DataContext = dataContext;
        }

        /// <summary>
    	/// Gets the specified entity by Id.
    	/// </summary>
    	/// <param name="id">The Campaign Id.</param>
    	public override Campaign GetById(int id)
        {
            try
            {
                return DataContext.Campaigns.FirstOrDefault(entity => entity.campaign_id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
    	/// Get All Campaigns.
    	/// </summary>
    	public override List<Campaign> GetAll()
        {
            try
            {
                return DataContext.Campaigns.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
    	/// Adds the specified entity.
    	/// </summary>
    	/// <param name="cm">The Campaign entity.</param>
    	public override Campaign Add(Campaign cm)
        {
            try
            {
                DataContext.Campaigns.Add(cm);
                DataContext.SaveChanges();
                return cm;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
    	/// Deletes the specified entity.
    	/// </summary>
    	/// <param name="cm">The Campaign entity.</param>
    	public override void Delete(Campaign cm)
        {
            try
            {
                DataContext.Campaigns.Remove(cm);
                DataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
    	/// Deletes the entity by Id.
    	/// </summary>
    	/// <param name="id">The Campaign Id.</param>
    	public override void Delete(int id)
        {
            try
            {
                var pr = GetById(id);
                DataContext.Campaigns.Remove(pr);
                DataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
    	/// Updates the specified entity.
    	/// </summary>
    	/// <param name="pr">The product entity.</param>
    	public override Campaign Update(Campaign cm)
        {
            try
            {
                var _cm = GetById(cm.campaign_id);
                DataContext.Entry(_cm).CurrentValues.SetValues(cm);
                DataContext.SaveChanges();
                return cm;
            }
            catch (Exception ex)
            {
                //ExceptionHandler.LogException(ex, System.Reflection.MethodInfo.GetCurrentMethod().Name, ExceptionHandler.LogThreshold.ERROR);
                throw ex;
            }
        }
    }
}