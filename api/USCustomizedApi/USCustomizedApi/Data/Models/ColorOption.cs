namespace USCustomizedApi.Data.Models
{
  public class ColorOption : BaseModel
  {
    public int ColorId { get; set; }
    public string ColorOptions { get; set; }
    public Color Color { get; set; }
  }
}
