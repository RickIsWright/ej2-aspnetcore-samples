#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EJ2CoreSampleBrowser.Controllers.Maps
{
    public partial class MapsController: Controller
    {
        public IActionResult Heatmap()
        {
            ViewBag.population = GetIndianPopulation();
            ViewBag.india = GetIndiaData();
            return View();
        }
        public object GetIndiaData()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/india.json");
            return JsonConvert.DeserializeObject(allText);
        }
        public object GetIndianPopulation()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/indianpopulation.js");
            return JsonConvert.DeserializeObject(allText);
        }
    }
}