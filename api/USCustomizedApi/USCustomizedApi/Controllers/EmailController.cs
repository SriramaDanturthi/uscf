namespace USCustomizedApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmailController : ControllerBase
{

  private readonly IMailService mailService;
  public EmailController(IMailService mailService)
  {
    this.mailService = mailService;
  }
  [HttpPost()]
  public async Task SendMail([FromForm] MailRequest request)
  {
    await mailService.SendEmailAsync(request);
  }
}
