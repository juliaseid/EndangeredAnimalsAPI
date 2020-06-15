using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EndangeredAnimalsAPI.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    //First block of params come from Individual Species query
    public int TaxonId { get; set; }
    public string SciName { get; set; }
    public string Family { get; set; }
    public string CommonName { get; set; }
    public string Category { get; set; }
    public string Population_Trend { get; set; }

    //The following params come from Narrative query
    public string Population { get; set; }
    public string GeographicRange { get; set; }
    public string Habitat { get; set; }
    public string Threats { get; set; }
    public string Conservation { get; set; }
    //This param comes from Countries by Species query
    public string Countries { get; set; }
    public string ImageURL { get; set; }

  }

}