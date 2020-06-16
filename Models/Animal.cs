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
    public int taxonid { get; set; }
    public string scientific_name { get; set; }
    public string CommonName { get; set; }
    public string category { get; set; }
    public string rationale { get; set; }
    public string populationtrend { get; set; }

    //The following params come from Narrative query
    public string population { get; set; }
    public string geographicrange { get; set; }
    public string habitat { get; set; }
    public string threats { get; set; }
    public string conservationmeasures { get; set; }
    //This param comes from Countries by Species query
    public string country { get; set; }
    public string ImageURL { get; set; }

  }

}