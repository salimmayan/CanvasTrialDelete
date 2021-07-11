using BacheloretteClient.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
// using DAL;
// using MeetingMaster;
using System.Threading.Tasks;
using System.IO;
using Microsoft.JSInterop;
// using System.Web.UI;


namespace BacheloretteClient.Controllers
{
    public class BachelorettesController : Controller
    {
        public IActionResult Index()
        {
            // var allBachelorettes = Bachelorette.GetAll();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            Console.WriteLine("Inside create GET");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Bachelorette newBachelorette)
        {
            // Bachelorette.Post(newBachelorette);
            Console.WriteLine("Inside create POST");
            Console.WriteLine("BacheloretteId is " + newBachelorette.BacheloretteId);
            Console.WriteLine("Description is " + newBachelorette.Description);
            Console.WriteLine("Base64 Id is " + newBachelorette.Base64); 
            string text = System.IO.File.ReadAllText(@"C:\Users\salimvay\OneDrive - Intel Corporation\Desktop\base64.txt");
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
            return RedirectToAction("Create");            
        } 
    }
}