namespace USCustomizedApi.ViewModels;
public class MailRequest
{
  public List<string> ToEmail { get; set; }
  public string Subject { get; set; }
  public string Body { get; set; }
  public List<IFormFile> Attachments { get; set; }
  public string PhoneNo { get; set; }
}
