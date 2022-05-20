using Microsoft.AspNetCore.Mvc;
using EntityFramework.Data;
using EntityFramework.Models;


namespace EntityFramework.Controllers;

[ApiController]
[Route("[controller]")]
public class NorthwindController : ControllerBase
{

    NorthwindContext nc;
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<NorthwindController> _logger;

    public NorthwindController(ILogger<NorthwindController> logger, NorthwindContext context)
    {
        _logger = logger;
        nc = context;
    }



    [HttpGet]
    [Route("categorias")]
    public IEnumerable<Category> Get()
    {
        return nc.Categories.ToList<Category>()
        .ToArray();
    }

    [HttpGet]
    [Route("productos")]
    public IEnumerable<Product> GetProducts()
    {
        return nc.Products.ToList<Product>()
        .ToArray();
    }

}
