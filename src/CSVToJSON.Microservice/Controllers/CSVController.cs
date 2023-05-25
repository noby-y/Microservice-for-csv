using Microsoft.AspNetCore.Mvc;

namespace CSVToJSON.Microservice.Controllers;

[ApiController]
[Route("[controller]")]
public class FieldController : Controller
{

    [HttpPost("csv-to-json")]
    public string GetCSV([FromForm] IFormFileCollection file)
    {
        return CSVService.ConvertToJson(file[0]);
    }

    // [HttpGet("get-some-random")]
    // public string Get(){
    //     return "something-something";
    // }
}