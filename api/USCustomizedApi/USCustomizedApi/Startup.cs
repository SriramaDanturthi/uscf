namespace USCustomizedApi;
public class Startup
{
  public Startup(IConfiguration configuration)
  {
    Configuration = configuration;
  }

  public IConfiguration Configuration { get; }

  // This method gets called by the runtime. Use this method to add services to the container.
  public void ConfigureServices(IServiceCollection services)
  {
    services.AddDbContext<USCustomizedContext>(options =>
    {
      options.UseSqlServer(Configuration.GetConnectionString("USCustomizedFinishes"));
    });

    services.AddControllers()
            .AddNewtonsoftJson();

    services.AddCors(options =>
    {
      options.AddDefaultPolicy(policy =>
      {
        policy.WithOrigins("http://localhost:4200", "http://localhost/uscustomized.com/").AllowAnyHeader().AllowAnyMethod();
      });
    });

    services.AddSwaggerGen(c =>
    {
      c.SwaggerDoc("v1", new OpenApiInfo { Title = "USCustomizedApi", Version = "v1" });
    });
    services.AddTransient<IProductsService, ProductsService>();
    services.AddTransient<IMailService, MailService>();
    services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
  }

  // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
  {
    if (env.IsDevelopment())
    {
      app.UseDeveloperExceptionPage();
      app.UseSwagger();
      app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "USCustomizedApi v1"));
    }

    app.UseHttpsRedirection();
    app.UseCors();

    app.UseRouting();

    app.UseAuthorization();

    app.UseEndpoints(endpoints =>
    {
      endpoints.MapControllers();
    });
  }
}
