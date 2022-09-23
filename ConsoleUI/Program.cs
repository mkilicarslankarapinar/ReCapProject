using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;


internal class Program
{
    private static void Main(string[] args)
    {
        //CarDetailTEST();
        //AddCarTEST();
        //UpdateCarTEST();
        //DeleteCarTEST();
        //GetAllCars();
        //BrandTEST();
        //ColorTEST();
        //GetCarsByBrandIdTEST();
        //GetCarsByColorIdTEST();


    }



    private static void GetCarsByColorIdTEST()
    {
        CarManager carManager = new CarManager(new EfCarDao());
        var result = carManager.GetCarsByColorId(2);

        if (result.Success == true)
        {
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }

    private static void GetCarsByBrandIdTEST()
    {
        CarManager carManager = new CarManager(new EfCarDao());
        var result = carManager.GetCarsByBrandId(2);
        if (result.Success == true)
        {
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }

    private static void ColorTEST()
    {
        ColorManager colorManager = new ColorManager(new EfColorDao());
        var result = colorManager.GetAll();
        if (result.Success == true)
        {
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
       
    }

    private static void BrandTEST()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDao());
        var result = brandManager.GetAll();
        if (result.Success == true)
        {
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
        
    }

    private static void GetAllCars()
    {
        CarManager carManager = new CarManager(new EfCarDao());
        var result = carManager.GetAllCars();
        if (result.Success == true)
        {
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }

    private static void DeleteCarTEST()
    {
        CarManager carManager = new CarManager(new EfCarDao());
        var car = new Car { CarId = 11 };
        carManager.Delete(car);
        Console.WriteLine("İşlem Başarılı");
    }

    private static void UpdateCarTEST()
    {
        CarManager carManager = new CarManager(new EfCarDao());
        var car = new Car { CarId=10, CarName = "Güllü", BrandId = 1, ColorId = 2, ModelYear = "2017", DailyPrice = 225, Description = "Duster" };
        carManager.Update(car);
        Console.WriteLine("İşlem Başarılı");
    }

    private static void AddCarTEST()
    {
        CarManager carManager = new CarManager(new EfCarDao());
        var car = new Car { CarId = 21 ,CarName = "Deneme1", BrandId = 3, ColorId = 2, ModelYear = "2010", DailyPrice = 125, Description = "Deneme1" };
        carManager.Add(car);
        Console.WriteLine("İşlem Başarılı");
    }

    private static void CarDetailTEST()
    {
        CarManager carManager = new CarManager(new EfCarDao());
        var result = carManager.GetCarDetails();
        if (result.Success == true)
        {
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }
}
