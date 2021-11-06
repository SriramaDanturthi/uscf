namespace USCustomizedApi.Data.Models
{
  public class ProductImage : BaseModel
  {
    public int ProductId { get; set; }
    public int ImageTypeId { get; set; }
    public string Path { get; set; }

    public Product Product { get; set; }
  }
}
