using ManyToMany.Entities;
using ManyToMany.Repositories;
using ManyToMany.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ManyToManyDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ManyToManyConStr")));

builder.Services.AddScoped<CourseRepository>();
builder.Services.AddScoped<StudentRepository>();
builder.Services.AddScoped<UnitOfWork>();
builder.Services.AddScoped<AddStudentService>();
builder.Services.AddScoped<AddCourseService>();
builder.Services.AddScoped<GetAllStudentsService>();
builder.Services.AddScoped<GetAllCoursesService>();
builder.Services.AddScoped<SelectUnitService>();

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
