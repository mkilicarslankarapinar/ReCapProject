using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

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

        foreach (var car in carManager.GetCarsByColorId(2))
        {
            Console.WriteLine(car.CarName);
        }
    }

    private static void GetCarsByBrandIdTEST()
    {
        CarManager carManager = new CarManager(new EfCarDao());
        foreach (var car in carManager.GetCarsByBrandId(2))
        {
            Console.WriteLine(car.CarName);
        }
    }

    private static void ColorTEST()
    {
        ColorManager colorManager = new ColorManager(new EfColorDao());
        foreach (var color in colorManager.GetAll())
        {
            Console.WriteLine(color.ColorName);
        }
    }

    private static void BrandTEST()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDao());
        foreach (var brand in brandManager.GetAll())
        {
            Console.WriteLine(brand.BrandName);
        }
    }

    private static void GetAllCars()
    {
        CarManager carManager = new CarManager(new EfCarDao());
        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.CarName);
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
        var car = new Car { CarName = "Güllü", BrandId = 1, ColorId = 5, ModelYear = "2017", DailyPrice = 225, Description = "Duster" };
        carManager.Add(car);
        Console.WriteLine("İşlem Başarılı");
    }

    private static void CarDetailTEST()
    {
        CarManager carManager = new CarManager(new EfCarDao());
        foreach (var car in carManager.GetCarDetails())
        {
            Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
        }
    }
}


//CarManager carManager = new CarManager(new EfCarDao());

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.DailyPrice);
//}