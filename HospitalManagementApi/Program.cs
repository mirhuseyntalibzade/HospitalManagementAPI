using HospitalManagementBL.Profiles;
using HospitalManagementBL.Services.Abstractions;
using HospitalManagementBL.Services.Implementations;
using HospitalManagementDAL.Contexts;
using HospitalManagementDAL.Repositories.Abstractions;
using HospitalManagementDAL.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
        options.JsonSerializerOptions.WriteIndented = true;
    }); ;

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("MsSql"));
    opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddScoped<IGenderRepository, GenderRepository>();
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IInsuranceRepository, InsuranceRepository>();
builder.Services.AddScoped<IGenderService, GenderService>();
builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<IInsuranceService, InsuranceService>();

builder.Services.AddAutoMapper(typeof(GenderProfiles));
builder.Services.AddAutoMapper(typeof(InsuranceProfiles));

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
