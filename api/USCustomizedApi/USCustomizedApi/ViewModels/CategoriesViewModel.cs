using System.Collections.Generic;

namespace USCustomizedApi.ViewModels
{
  public class CategoriesViewModel
  {
    public string Slug { get; set; }
    public string Name {  get; set; }
    public string Image { get; set; }
    public IEnumerable<CategoriesViewModel> Children {  get; set; }
  }
}
