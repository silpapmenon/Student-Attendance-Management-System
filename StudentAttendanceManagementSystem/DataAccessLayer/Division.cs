//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Division
    {
        public int DivisionID { get; set; }
        public string DivisionName { get; set; }
        public int StandardID { get; set; }
        public int Seat { get; set; }
    
        public virtual Standard Standard { get; set; }
    }
}
