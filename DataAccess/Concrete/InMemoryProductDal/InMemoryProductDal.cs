using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemoryProductDal
{
    public class InMemoryProductDal : IProductDal
    {

        List<Car> _cars;
        public InMemoryProductDal()
        {
            _cars = new List<Car>{
                new Car{Id=1,BrandId=8,ColorId="1", ModelYear="2018", DailyPrice=540, Description="Fiat Egea 1.3"},
                new Car{Id=2,BrandId=7,ColorId="2",ModelYear="2016", DailyPrice=890,Description="Opel Insignia 1.6"},
                new Car{Id=3,BrandId=6,ColorId="3",ModelYear="2016",DailyPrice=650,Description="Ford Kuga 1.5"},
                new Car{Id=4,BrandId=6,ColorId="2",ModelYear="2015",DailyPrice=590,Description="Ford Focus 1.5"},
                new Car{Id=5,BrandId=5,ColorId="2",ModelYear="2019",DailyPrice=2200,Description="Volvo CX90 2.0"}
            };
        }
        
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
         
            Car carToDelete = carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id );
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            
        }
    }
}
