//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight
    {
        public string FlightID { get; set; }
        public string Class { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Duration { get; set; }
        public System.DateTime FlightDate { get; set; }
        public string AircraftID { get; set; }
        public string MealID { get; set; }
        public string RouteID { get; set; }
        public string FareID { get; set; }
    }
}
