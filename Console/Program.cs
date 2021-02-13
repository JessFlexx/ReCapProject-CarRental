using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemoryProductDal;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var car in productManager.GetAll())
            {
                System.Console.WriteLine(car.Description+"\tYear:"+car.ModelYear +"\nDaily price -> " +car.DailyPrice+"\n");
            }



        }
    }
}
