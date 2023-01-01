using Microsoft.EntityFrameworkCore;
using MovieApplication.Data;
using MovieApplication.Models;
using MovieApplication.Realizations.classes;
using MovieApplication.Realizations.interfaces;
using MovieApplication.Services.ClassesRepository;
using MovieApplication.Services.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Realization Services
builder.Services.AddScoped<IActorInfo, ActorRealization>();

builder.Services.AddScoped<IProducerInfo, ProducerRealization>();

builder.Services.AddScoped<IMovieInfo, MovieRealization>();

builder.Services.AddScoped<ICinemaInfo, CinemaRealization>();

builder.Services.AddScoped<IActor_MovieInfo, Movie_ActorRealization>();

// Repository Rervices
builder.Services.AddTransient<IActorRepository, ActorRepository>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
   
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movies}/{action=Index}/{id?}");

app.Run();
