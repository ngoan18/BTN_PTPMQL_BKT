using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace BTN_PTPMQL_BKT;
public class BUITHINGOANController : Controller
{
    public IActionResult Index ()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Index ( string Hoten, string Diachi)
    {
        ViewBag.a= Hoten + "- " +Diachi;
        return View();
    }
}