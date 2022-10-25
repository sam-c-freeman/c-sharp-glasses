using SeeSharpGlasses.Models;
using SeeSharpGlasses.Services;
using Microsoft.AspNetCore.Mvc;

namespace GlassesController.Controllers;

[ApiController]
[Route("[controller]")]
public class GlassesController : ControllerBase
{
    public GlassesController()
    {
    }

    // GET all action
    [HttpGet]
public ActionResult<List<Glasses>> GetAll() =>
    GlassesService.GetAll();

    // GET by Id action

    // POST action

    // PUT action

    // DELETE action
}