//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAMP.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Campaign
    {
        public int campaign_id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public decimal budget { get; set; }
        public string Goal { get; set; }
        public string Category { get; set; }
        public Nullable<System.DateTime>Date {get; set; }
        public string URL { get; set; }
    }
}