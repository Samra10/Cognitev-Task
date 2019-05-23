using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CAMP.Model;

namespace CAMP.UI.Controllers
{
    public class CampaignsController : Controller
    {

        // GET: Campaigns
        public async Task<ActionResult> Index()
        {
            return View();
        }

        // GET: Campaigns/Details/5
        public async Task<ActionResult> Details(int? id)
        {
          
            return View();
        }

        // GET: Campaigns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Campaigns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "campaign_id,name,country,budget,Goal,Category,Date,URL")] Campaign campaign)
        {
            /*if (ModelState.IsValid)
            {
                db.Campaigns.Add(campaign);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }*/

            return View();
        }

        // GET: Campaigns/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
           /* if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campaign campaign = await db.Campaigns.FindAsync(id);
            if (campaign == null)
            {
                return HttpNotFound();
            }*/
            return View();
        }

        // POST: Campaigns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "campaign_id,name,country,budget,Goal,Category,Date,URL")] Campaign campaign)
        {
            /*if (ModelState.IsValid)
            {
                db.Entry(campaign).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }*/
            return View();
        }

        // GET: Campaigns/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
           /* if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campaign campaign = await db.Campaigns.FindAsync(id);
            if (campaign == null)
            {
                return HttpNotFound();
            }*/
            return View();
        }

        // POST: Campaigns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            /*Campaign campaign = await db.Campaigns.FindAsync(id);
            db.Campaigns.Remove(campaign);
            await db.SaveChangesAsync();*/
            return RedirectToAction("Index");
        }

    }
}
