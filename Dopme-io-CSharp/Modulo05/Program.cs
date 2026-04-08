using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using Modulo05.DependencyInjection.Services;
using Modulo05.JWT.Services;
using Modulo05.ServiceLifetime.Extensions;
using ITarefaService = Modulo05.DependencyInjection.Services.ITarefaService;
using TarefaService = Modulo05.DependencyInjection.Services.TarefaService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddAntiforgery();
builder.Services.AddScoped<ITarefaService,TarefaService>();
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.UseContadores();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen
(opt =>
    {
        opt.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Api Documentação",
            Version = "v1",
            Description = "Api para documentar projetos",
            Contact = new OpenApiContact
            {
                Email = "edgard@gmail.com"
            },
            License = new OpenApiLicense
            {
                Url = new Uri(
                    "https://github.com/dopme-io/dopmeEdgardMoraes/blob/main/templates/treinamento-iniciante/modulo-05-aspnet-core/exercicios/Exerc%C3%ADcio%2014.1.pdf")
            }
        });
    }
);

var jwt = builder.Configuration.GetSection("Jwt");
var key = Encoding.UTF32.GetBytes(jwt["Key"]!);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer
(opt =>
    {
            
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = true,
            ValidIssuer = jwt["Issuer"],
            ValidateAudience = true,
            ValidAudience = jwt["Audience"],
            ValidateLifetime = true,
            ClockSkew = TimeSpan.FromDays(1)
        };
    }
);

//implementar as policies
builder.Services.AddAuthorization();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(opt => { opt.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiSwagger v1"); });
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();