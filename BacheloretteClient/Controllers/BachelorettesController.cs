using BacheloretteClient.Models;
using Microsoft.AspNetCore.Mvc;
using System;

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
      return RedirectToAction("Create");
    }
  }
}