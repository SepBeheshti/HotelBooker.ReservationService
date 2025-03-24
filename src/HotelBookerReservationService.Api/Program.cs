using HotelBooker.ReservationService.Api.Mappers;
using Microsoft.EntityFrameworkCore;
using HotelBooker.ReservationService.Data;
using HotelBooker.ReservationService.Data.Repositories;
using HotelBooker.ReservationService.Business.Services;
using HotelBooker.ReservationService.Business.Mappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext
builder.Services.AddDbContext<ReservationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register repositories
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();

// Register services
builder.Services.AddScoped<IReservationService, ReservationService>();

// Register mappers
builder.Services.AddScoped<ReservationRequestMapper>();
builder.Services.AddScoped<ToReservationEntityMapper>();
builder.Services.AddScoped<ToReservationMapper>();

var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();