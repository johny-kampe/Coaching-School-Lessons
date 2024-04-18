using CoachingSchoolLeassons.API.Data;
using CoachingSchoolLeassons.API.Interfaces;
using CoachingSchoolLeassons.API.Mappings;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CoachingSchoolDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("CoachingSchoolLessonsConnectionString")));

builder.Services.AddScoped<IUserRepository, SqlUserRepository>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
