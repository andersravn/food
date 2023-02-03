using FoodApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace FoodApp.Controllers;

public class FoodListController : RenderController
{
    private readonly HttpClient _httpClient; 
    public FoodListController(ILogger<FoodListController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor, HttpClient httpClient) : base(logger, compositeViewEngine, umbracoContextAccessor)
    {
        _httpClient = httpClient;
    }

    [HttpGet]
    public async Task<IActionResult> Index(CancellationToken cancellationToken)
    {
        var response = await _httpClient.GetAsync("https://localhost:7147/api/FoodItems", cancellationToken);
        var list = await response.Content.ReadFromJsonAsync<List<Food>>(cancellationToken: cancellationToken);
        return CurrentTemplate(list);
    }
}