using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using USCustomizedApi.Services;
using USCustomizedApi.ViewModels;

namespace USCustomizedApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductsController : ControllerBase
  {
    IProductsService _productsService;
    public ProductsController(IProductsService productsService)
    {
      _productsService = productsService;
    }
    [HttpGet("brands")]
    public IEnumerable<BrandViewModel> GetBrands()
    {
      return _productsService.GetBrands();
    }
    [HttpGet("popularcategories")]
    public IEnumerable<CategoriesViewModel> GetPopularCategories()
    {
      return _productsService.GetPopularCategories();
    }
  }
}
