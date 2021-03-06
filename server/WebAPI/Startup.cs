using System.Text;
using AutoMapper;
using Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using WebAPI.Options;
using WebAPI.DTO;
using WebAPI.Services;
using WebAPI.Interfaces;
using System.IO;
using Entities.Models;
using Microsoft.Extensions.FileProviders;
using WebAPI.Services.Assets;
using Entities.Interfaces;

namespace WebAPI
{
  public class Startup
  {
    readonly string VueCorsPolicy = "_vueCorsPolicy";
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      var frontConfiguration = Configuration.GetSection("Front").Get<FrontConfiguration>();
      services.AddCors(options =>
      {
        options.AddPolicy(name: VueCorsPolicy,
                                builder =>
                                {
                                  builder
                                          .AllowAnyHeader()
                                          .AllowAnyMethod()
                                          .AllowCredentials()
                                          .WithOrigins(frontConfiguration.AddressFront);
                                });
      });

      services.AddDbContext<IRepositoryContext, RepositoryContext>(options =>
          options.UseSqlServer(Configuration.GetConnectionString("mssqlConnection")));
      services.AddSingleton(Configuration);
      services.AddScoped<UserRepository>();
      services.AddScoped<CountryRepository>();
      services.AddScoped<LanguageRepository>();
      services.AddScoped<TicketsRepository>();      
      services.AddScoped<TicketsService>();
      services.AddScoped<IWaypointRepository, WaypointRepository>();
      services.AddScoped<IWaypointFileRepository, WaypointFileRepository>();
      services.AddScoped<IWaypointService, WaypointService>();
      services.AddScoped<IWaypointFileService, WaypointFileService>();
      services.AddScoped<UserService>();
      services.AddSingleton<AuthService>();
      services.AddScoped<ITripRepository, TripRepository>();
      services.AddScoped<ITripService, TripService>();
      services.AddSingleton(frontConfiguration);
      services.AddScoped<RecoveryPasswordService>();
      services.AddSingleton(Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>());
      services.AddScoped<IEmailSender, EmailSender>();
      services.AddScoped<IGoogleOauthService, GoogleOauthService>();
      services.AddScoped<IGooglePlacePhotoService, GooglePlacePhotoService>();
      services.AddScoped<AssetsService>();
      services.AddTransient<IAttachmentFileEatingRepository, AttachmentFileEatingRepository>();
      services.AddTransient<IAttachmentFileEatingService, AttachmentFileEatingService>();
      services.AddTransient<IScheduledPlaceToEatRepository, ScheduledPlaceToEatRepository>();
      services.AddTransient<IScheduledPlaceToEatService, ScheduledPlaceToEatService>();
      services.AddScoped<IEntertainmentService, EntertainmentService>();
      services.AddScoped<IEntertainmentRepository, EntertainmentRepository>();
      services.AddScoped<AccommodationService>();
      services.AddScoped<AccommodationRepository>();

      services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
          .AddJwtBearer(x =>
      {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
          ValidateIssuerSigningKey = true,
          IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration["Jwt:Key"])),
          ValidateIssuer = true,
          ValidIssuer = Configuration["Jwt:Issuer"],
          ValidateAudience = true,
          ValidAudience = Configuration["Jwt:Audience"]
        };
      });
      services.AddControllers();

      services.AddSwaggerGen(x =>
      {
        x.SwaggerDoc("v1", new OpenApiInfo { Title = "MyTrip Api", Version = "v1" });
      });

      var mappingConfig = new MapperConfiguration(mc =>
      {
        mc.AddProfile(new MappingProfile());
      });

      services.AddSingleton(mappingConfig.CreateMapper());

      services.AddDirectoryBrowser();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if(env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      var swaggerOptions = new SwaggerOptions();
      Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);

      app.UseSwagger(option =>
      {
        option.RouteTemplate = swaggerOptions.JsonRoute;
      });

      app.UseSwaggerUI(option =>
      {
        option.SwaggerEndpoint(swaggerOptions.UiEndpoint, swaggerOptions.Description);
      });

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseCors(VueCorsPolicy);

      app.UseAuthentication();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });

      app.UseFileServer(new FileServerOptions
      {
        FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), Consts.AssetsPath)),
        RequestPath = "/assets",
        EnableDirectoryBrowsing = true,
        StaticFileOptions = { ServeUnknownFileTypes = true}
      });
      app.UseFileServer(new FileServerOptions
      {
        FileProvider = new PhysicalFileProvider(
                          Path.Combine(Directory.GetCurrentDirectory(), Consts.EntertainmentsPath)),
        RequestPath = "/entertainment",
        EnableDirectoryBrowsing = true
      });
      app.UseFileServer(new FileServerOptions
      {
        FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), Consts.AccommodationsPath)),
        RequestPath = "/accommodations",
        EnableDirectoryBrowsing = true
      });
      app.UseFileServer(new FileServerOptions
      {
        FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), Consts.FileEatingPath)),
        RequestPath = "/scheduledPlaceToEat",
        EnableDirectoryBrowsing = true
      });
    }
  }
}
