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
using EJ2CoreSampleBrowser.Models;
using Syncfusion;

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class RichtextEditorController : Controller
    {
        public IActionResult FileBrowser()
        {
            string hostUrl = "https://ej2-aspcore-service.azurewebsites.net/";
            ViewBag.ajaxSettings = new {
                url = hostUrl + "api/FileManager/FileOperations",
                getImageUrl = hostUrl + "api/FileManager/GetImage",
                uploadUrl = hostUrl + "api/FileManager/Upload",
                downloadUrl = hostUrl + "api/FileManager/Download"
            };
            ViewBag.tools = new[] { "FileManager", "Image" };
            return View();
        }
    }
}
