namespace USCustomizedApi.Data.Models;
public class Panel : BaseModel
{
  public string PanelName { get; set; }
  public int PanelTypeId { get; set; }
  public string Path { get; set; }
  public PanelType PanelType { get; set; }
}
