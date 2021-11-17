using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using USCustomizedApi.Data;
using USCustomizedApi.ViewModels;

namespace USCustomizedApi.Services
{
  public interface IProductsService
  {
    IEnumerable<BrandViewModel> GetBrands();
    IEnumerable<CategoriesViewModel> GetPopularCategories();
  }
  public class ProductsService : IProductsService
  {
    USCustomizedContext _context;
    public ProductsService(USCustomizedContext context)
    {
      _context = context;
    }
    private static string GetImagePath(string path)
    {
      return path != null ? path.Replace("img", "images").Substring(0, path.LastIndexOf('/') + 3) +
          path.Replace("img", "images").Substring(path.LastIndexOf('/') + 3).ToLower() : "";
    }
    public IEnumerable<BrandViewModel> GetBrands()
    {
      return _context.ProductImages.Include("Product").Where(t => t.ImageTypeId == 2).OrderBy(t => Guid.NewGuid()).Take(16).Select(t => new BrandViewModel
      {
        Image = GetImagePath(t.Path),
        Name = t.Product.ProductCode + ""
      });
    }

    public IEnumerable<CategoriesViewModel> GetPopularCategories()
    {
      return _context.Categories.Where(t => t.ParentId == null).OrderBy(t => Guid.NewGuid()).Take(3).Select(t => new CategoriesViewModel
      {
        Slug = t.CategoryName.Replace(" ", ""),
        Name = t.CategoryName,
        Image = GetImagePath(_context.ProductImages.FirstOrDefault(pi => !pi.IsDrawing && pi.ProductId == _context.Products.Where(p => _context.Categories.Where(c => c.ParentId == t.Id && c.Id == p.CategoryId).OrderBy(cc => Guid.NewGuid()).Any(d => d.Id == p.CategoryId)).OrderBy(cc => Guid.NewGuid()).FirstOrDefault().Id).Path),
        Children = _context.Categories.Where(c => c.ParentId == t.Id).Select(cc => new CategoriesViewModel { Name = cc.CategoryName }).AsEnumerable()
      });
    }
  }
}
