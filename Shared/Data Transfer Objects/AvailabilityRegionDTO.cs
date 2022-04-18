using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    /// <summary>
    /// Schema for Availaibilty Region 
    /// Author: Aditya Sharma 
    /// </summary>
    public class AvailabilityRegionDTO
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public decimal? ServiceAmount { get; set; }
        public DateTime? NextAvailableDate { get; set; }
    }
}
