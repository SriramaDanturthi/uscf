namespace USCustomizedApi.Data.Models
{
  public class Category : BaseModel
  {
    public string CategoryName {  get; set; }
    public string Description {  get; set; }
    public string CategoryCode { get; set; }
    public int? ParentId {  get; set; }
  }
}
