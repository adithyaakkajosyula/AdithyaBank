﻿
using Microsoft.AspNetCore.Mvc;
using AdithyaBank.BackEnd.Models;
using AdithyaBank.FrontEnd.Models;
using System.Buffers.Text;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using System.Security.Claims;
using AdithyaBank.BackEnd.Authorization;

namespace AdithyaBank.FrontEnd.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Authorize]
        public IActionResult Index()
        {
            var user = (UserModel)HttpContext.Items["User"];

            /*var FullName = HttpContext.User.Claims.First(c => c.Type == ClaimTypes.Name).Value;
            var UserID = HttpContext.User.Claims.First(c => c.Type == ClaimTypes.Sid).Value;*/
            return View(user);
        }

        public IActionResult Privacy()
        {
            List<AudioModel> audiomodellist = new List<AudioModel>();
            List<string> allFiles = new List<string>();
            string[] drives = Environment.GetLogicalDrives();
            foreach (string drive in drives)
            {

                if (drive != "C:\\")
                {
                    List<string> directfiles = Directory.EnumerateFiles(drive, "*.mp3*",
                   new EnumerationOptions
                   {
                       IgnoreInaccessible = true,
                       RecurseSubdirectories = true,
                   }).ToList();
                    allFiles.AddRange(directfiles);
                }


            }


            foreach (string file in allFiles)
            {
                byte[] fileByte = FileToByteArray(file);
                string base64 = Convert.ToBase64String(fileByte);
                base64 = "data:audio/wav;base64," + base64;

                var model = new AudioModel();
                model.base64 = base64;
                model.songname = Path.GetFileName(file);
                audiomodellist.Add(model);
            }
            return View(audiomodellist);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public static byte[] FileToByteArray(string fileName)
        {
            byte[] ? fileData = null;

            using (FileStream fs = System.IO.File.OpenRead(fileName))
            {
                var binaryReader = new BinaryReader(fs);
                fileData = binaryReader.ReadBytes((int)fs.Length);
            }
            return fileData;
        }
    }
}