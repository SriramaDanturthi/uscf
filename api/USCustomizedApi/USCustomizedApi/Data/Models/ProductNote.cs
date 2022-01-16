namespace USCustomizedApi.Data.Models;
public class ProductNote : BaseModel
{
  public int ProductId { get; set; }
  public int NoteId { get; set; }
  public Product Product { get; set; }
  public Note Note { get; set; }
}
