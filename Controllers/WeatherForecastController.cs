using Microsoft.AspNetCore.Mvc;

namespace codingC.Controllers;

[ApiController]
[Route("test")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet("Oi")]
   public ActionResult outrotest(){
       return Content(@"
           <marquee>
                <h1> 
                Hello World Estamos dominando tudo rapaz
                </h1>
            </marquee>", "text/html") ;
   }
    [HttpGet]
    public string Test(){
        return "Meu backend está rodando";

    }
}
