using Business_Logic__Layer.BLL;
using Business_Logic__Layer.Interface;
using Data_BaseLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<StudyContext>(opts => opts.UseSqlServer(builder.Configuration["ConnectionStrings:StudyDB"]));

builder.Services.AddTransient<ICampus,CampusService>();
builder.Services.AddTransient<IProfessor, ProfessorService>();
builder.Services.AddTransient<IPrincipal, PrincipalService>();
builder.Services.AddTransient<ICourse, CourseService>();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
