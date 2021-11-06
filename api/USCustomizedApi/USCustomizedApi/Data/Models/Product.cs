namespace USCustomizedApi.Data.Models
{
  public class Product : BaseModel
  {
    public string ProductCode { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
  }
}
