using System.Diagnostics;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;


namespace DojoSurvey.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public ViewResult FormView()
    {
        return View("FormView");
    }

    // [HttpGet("results")]
    // public ViewResult ResultsView(string Name, string Location, string Language, string Comment)
    // {
    //     ViewBag.Name=Name;
    //     return View("ResultsView");
    // }

    // [HttpPost("process")]
    // public RedirectToActionResult Process(string Name, string Location, string Language, string Comment) 
    // {
    //     //checked data was retreived
    //     Console.WriteLine(Name);
    //     Console.WriteLine(Location);
    //     Console.WriteLine(Language);
    //     Console.WriteLine(Comment);
       
    //     return RedirectToAction("ResultsView");
    // }

    [HttpPost("process")]
    public ViewResult Process(string Name, string Location, string Language, string Comment) 
    {
        //checked data was retreived
        Console.WriteLine(Name);
        Console.WriteLine(Location);
        Console.WriteLine(Language);
        Console.WriteLine(Comment);

        ViewBag.Name=Name;
        ViewBag.Location=Location;
        ViewBag.Language=Language;
        ViewBag.Comment=Comment;
       
        return View("ResultsView");
    }



}
