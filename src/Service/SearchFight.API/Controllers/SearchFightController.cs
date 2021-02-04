using Microsoft.AspNetCore.Mvc;
using SearchFight.Domain.Services;
using System;
using System.Threading.Tasks;

namespace SearchFight.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SearchFightController : ControllerBase
  {
    private readonly ISearchFightService _service;


    public SearchFightController(ISearchFightService service)
    {
      _service = service ?? throw new ArgumentNullException(nameof(service));
    }


    public async Task<IActionResult> GetSearchFight([FromQuery] string[] list)
    {
      var result = await _service.Fight(list);

      return Ok(result);
    }

  }
}
