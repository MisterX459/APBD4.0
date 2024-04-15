using Microsoft.AspNetCore.Mvc;

namespace APBD4._0;


[ApiController]
[Route("/animals")]
public class Controller : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = StaticData.animals;
        return Ok();
    }
}