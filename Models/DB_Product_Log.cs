//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Integrated_B2B.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DB_Product_Log
    {
        public int id { get; set; }
        public int Prod_Id { get; set; }
        public Nullable<double> Stock_Live { get; set; }
        public Nullable<double> Stock_Total_Incoming { get; set; }
        public Nullable<double> Stock_Total_Outgoing { get; set; }
    
        public virtual DB_Product DB_Product { get; set; }
    }
}