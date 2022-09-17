using Microsoft.AspNetCore.Mvc;
using static  System.IO.File;
namespace codingC.Controllers;

[ApiController]

public class WeatherForecastController : ControllerBase
{
    [HttpGet]
   public ActionResult index(){
       

       return Content(ReadAllText("view/index.html"), "text/html") ;
   }
   [HttpGet("/login")]
   public ActionResult Login(){
       

       return Content(ReadAllText("view/index.html"), "text/html") ;
   }
    
}
