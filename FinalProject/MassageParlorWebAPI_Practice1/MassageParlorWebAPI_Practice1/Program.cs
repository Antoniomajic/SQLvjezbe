using MassageParlorWebAPI_Practice1.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(sgo => { // sgo je instanca klase SwaggerGenOptions
    // èitati: https://devintxcontent.blob.core.windows.net/showcontent/Speaker%20Presentations%20Fall%202017/Web%20API%20Best%20Practices.pdf
    var o = new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title = "Massage Parlor API Practice1",
        Version = "v1",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact()
        {
            Email = "antonio.majich@gmail.com",
            Name = "Antonio Majiæ"
        },
        Description = "This is documentation for Massage Parlor API",
        License = new Microsoft.OpenApi.Models.OpenApiLicense()
        {
            Name = "Educational licence"
        }
    };
    sgo.SwaggerDoc("v1", o);
});

builder.Services.AddDbContext<MassageParlorContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString(name: "MassageParlorContext")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options => options.SerializeAsV2 = true);
    app.UseSwaggerUI(options => options.ConfigObject.AdditionalItems.Add("requestSnippetsEnabled",true));
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
