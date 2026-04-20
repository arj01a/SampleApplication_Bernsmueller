using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SampleApplication.BusinessLayer;
using SampleApplication.Domain.Context;
using SampleApplication.Domain.Repository;
using SampleApplication.Infrastructure.Context;
using SampleApplication.Infrastructure.Repository;
using SampleApplication.WebApi.Mapping;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<QueryDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<CommandDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetAssembly(typeof(MediatorLibrary))));

builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(MappingProfile)));

builder.Services.AddTransient<IQueryDbContext, QueryDbContext>();
builder.Services.AddTransient<ICommandDbContext, CommandDbContext>();
builder.Services.AddTransient<IAccountQueryRepository, AccountQueryRepository>();
builder.Services.AddTransient<IPersonQueryRepository, PersonQueryRepository>();
builder.Services.AddTransient<IPersonCommandRepository, PersonCommandRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        policy => policy.SetIsOriginAllowed(origin => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());

});

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("CorsPolicy");

app.MapFallbackToFile("/index.html");

app.Run();
