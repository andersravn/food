using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Core.Services;

namespace FoodApp.Controller;

public class FoodsController : UmbracoApiController
{
    private IContentService _contentService;

    public FoodsController(IContentService contentService)
    {
        _contentService = contentService;
    }
    
    [HttpPost]
    public IActionResult GetAllProducts(string csv)
    {
        
        return null;
    }
}