namespace USCustomizedApi.Data.Models;
public class ProductProperty : BaseModel
{
  public int ProductId { get; set; }
  public int PropertyId { get; set; }
  public string PropertyValue { get; set; }
  public string Note { get; set; }
  public Product Product { get; set; }
  public Property Property { get; set; }
}
