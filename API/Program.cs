using Api.Middleware;
using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StoreContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});

// Adding the cors policies.
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
//app.UseDeveloperExceptionPage(); this is done in the background code by default.
app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(opt =>
{
    opt.AllowAnyHeader().AllowAnyMethod().AllowCredentials().WithOrigins("http://localhost:3000");
});
app.UseAuthorization();

app.MapControllers();

// Creating the database via code.
IServiceScope scope = app.Services.CreateScope();
StoreContext context = scope.ServiceProvider.GetRequiredService<StoreContext>();
ILogger logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

try
{

    context.Database.Migrate();
    DbInitializer.Initialize(context);
}
catch (Exception ex)
{
    logger.LogError(ex, "A problem occured during migration.");
}

app.Run();
