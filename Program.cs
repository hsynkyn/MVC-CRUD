using Microsoft.EntityFrameworkCore;
using MVC_CRUD.Infrastructure.Context;
using MVC_CRUD.Services.Concrete;
using MVC_CRUD.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("SQLConnection");

// DbContext'imizi tan�mlamam�z gerekiyor.
builder.Services.AddDbContext<AppDbContext>(options =>
{
    // Vede SqlServer kullanaca��m�z� bildirmemiz gerekiyor.
    options.UseSqlServer(connectionString);
});

// SERV�S �M�RLER�
// Singleton : Tek bir nesne �ret ve projenin her yerinde o nesneyi kullan
//builder.Services.AddSingleton<IPersonRepository, IPersonRepository>();

// Transient : Her bir talepte yeni bir tane olu�tur.
//builder.Services.AddTransient<IPersonRepository, IPersonRepository>();

// Scoped : Her bir HTTP requesti ba��na bir adet nesne �ret. En �ok bu kullan�l�r.
builder.Services.AddScoped<IPersonRepository, PersonRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
