namespace USCustomizedApi.Data.Models;
public class ProductEdgeProfile : BaseModel
{
  public int ProductId { get; set; }
  public int EdgeProfileId { get; set; }
  public Product Product { get; set; }
  public EdgeProfile EdgeProfile { get; set; }
}
