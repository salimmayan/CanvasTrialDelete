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
        // [HttpPost]
        // public IActionResult Index(Bachelorette bachelorette)
        // {
        //   Bachelorette.Post(bachelorette);
        //   return RedirectToAction("Index");
        // }
        // public IActionResult Details(int id)
        // {
        //   var bachelorette = Bachelorette.GetDetails(id);
        //   return View(bachelorette);
        // }
        // public IActionResult Edit(int id)
        // {
        //   var bachelorette = Bachelorette.GetDetails(id);
        //   return View(bachelorette);
        // }
        // [HttpPost]
        // public IActionResult Details(int id, Bachelorette bachelorette)
        // {
        //   bachelorette.BacheloretteId = id;
        //   Bachelorette.Put(bachelorette);
        //   return RedirectToAction("Details", id);
        // }
        // public IActionResult Delete(int id)
        // {
        //   Bachelorette.Delete(id);
        //   return RedirectToAction("Index");
        // }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Bachelorette newBachelorette)
        {
            // Bachelorette.Post(newBachelorette);
            Console.WriteLine("BacheloretteId is " + newBachelorette.BacheloretteId);
            Console.WriteLine("Description is " + newBachelorette.Description);
            Console.WriteLine("Bachelor Id is " + newBachelorette.Base64);

            // string script = string.Format("localStorage.userId= '{0}';", "12345");
            // Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "key", script, true);
            // var _isSupportLocalStorage = (('localStorage' in window) && (window['localStorage'] !== null));
            // window.localStorage.getItem(b64StringID);
            //       var storageItem = Request.Form["b64StringID"];
            //        Console.WriteLine("storageItem is " + storageItem);
            // var myStorage = window.localStorage;
            // const cat = myStorage.getItem('b64StringID');
            // result = ProtectedLocalStorage.Equals("b64StringID");
  
            // ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", "Showalert();", true);
            // ScriptManager.RegisterClientScriptBlock(UpdatePanel1, this.GetType(), "script", "alert('Hi');", true);
// inject ProtectedLocalStorage LocalStorage;

            return RedirectToAction("Create");
            // var ls = localStorage;
            //       var custStr = ls.getItem("b64StringID");

            // @inject ProtectedLocalStorage LocalStorage;
            // <p>@TxtFromLocalStorage</p>


            // private string TxtFromLocalStorage = string.Empty;
            // private const string _localStorage = "b64StringID";

            // protected override async Task OnInitializedAsync()
            // {
            //     var result = await LocalStorage.GetAsync<string>(_localStorage);
            //     TxtFromLocalStorage = result.Success ? result.Value : "Can't read local storage";
            // }
        }

// public class JsInteropClasses1
// {
//     private readonly IJSRuntime js;

//     public JsInteropClasses1(IJSRuntime js)
//     {
//         this.js = js;
//     }

//     public async ValueTask TickerChanged(string symbol, decimal price)
//     {
//         await js.InvokeVoidAsync("displayTickerAlert1", symbol, price);
//     }

//     public void Dispose()
//     {
//     }
// }
        // public ActionResult CreateMtng(MeetingVM objVm)
        // {
        //     Data access layer object    
        //     DAL objDal = newDAL();    

        //     //meeting master object created     
        //     MeetingMaster mtngMasterDetails = newMeetingMaster();    

        //     mtngMasterDetails.Name = objVm.mtngNameCovered.MtngName.ToString();    
        //     mtngMasterDetails.Agenda_Covered = objVm.agendaCovered.AgendaName.ToString().Trim();    
        //     mtngMasterDetails.Date_Of_Meeting = objVm.mtngDate.DateOfMeeting.ToString().Trim();    
        //     mtngMasterDetails.End_Time = objVm.mtngDate.EndTime.ToString().Trim();    
        //     mtngMasterDetails.Start_Time = objVm.mtngDate.StartTime.ToString().Trim();     
        //     //added to the in memory    
        //     objDal.mtngMaster.Add(mtngMasterDetails);    

        //     //saved to db    
        //     objDal.SaveChanges();       
        // }
    }
}