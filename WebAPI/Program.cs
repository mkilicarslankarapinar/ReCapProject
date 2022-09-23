using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddSingleton<ICarService, CarManager>();
builder.Services.AddSingleton<ICarDao, EfCarDao>();

builder.Services.AddSingleton<IBrandService, BrandManager>();
builder.Services.AddSingleton<IBrandDao, EfBrandDao>();

builder.Services.AddSingleton<IColorService, ColorManager>();
builder.Services.AddSingleton<IColorDao, EfColorDao>();

builder.Services.AddSingleton<IUserService, UserManager>();
builder.Services.AddSingleton<IUSerDao, EfUserDao>();

builder.Services.AddSingleton<ICustomerService, CustomerManager>();
builder.Services.AddSingleton<ICustomerDao, EfCustomerDao>();

builder.Services.AddSingleton<IRentalService, RentalManager>();
builder.Services.AddSingleton<IRentalDao, EfRentalDao>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
