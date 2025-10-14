using Microsoft.AspNetCore.Mvc;
using Custom_Asset_API.Services;

namespace Custom_Asset_API.Controllers;

[ApiController]
[Route("[controller]")]
public class AssetController : ControllerBase
{
    private readonly ILogger<AssetController> _logger;

    public AssetController(ILogger<AssetController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<List<Asset>> GetAll() =>
        AssetService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Asset> Get(int id)
    {
        var asset = AssetService.Get(id);

        if(asset == null)
            return NotFound();

        return asset;
    }
}
