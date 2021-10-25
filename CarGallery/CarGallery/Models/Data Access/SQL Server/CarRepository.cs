using CarGallery.Models.Abstraction;
using CarGallery.Models.Additional_Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Models.Data_Access.SQL_Server
{
    public class CarRepository : ICarRepository
    {
        public CarGalleryDataClassesDataContext CarDataContext { get; set; }

        public CarRepository()
        {
            CarDataContext = new CarGalleryDataClassesDataContext();
        }

        public Car GetData(int id)
        {
            var car = CarDataContext.Cars.FirstOrDefault(c => c.IdCars == id);



            return car;

        }

        public ObservableCollection<Car> GetAllData()
        {
          //  var cars = from b in CarDataContext.Cars select b;

            var cars = CarDataContext.Cars.GroupBy(x => new { x.IdCars, x.CarBodyStyle.IdCarBodyStyles, x.CarBodyStyle.Name_of_Car_Body_Styles, x.CarBrandsandModel.IdCarBrandsandModels, 
              x.CarBrandsandModel.BrandsandModels_of_car, x.CarBrandsandModel.Images_of_car , x.CarColor.IdCarColors, x.CarColor.Name_of_Car_Color, x.CarEnginePower.IdCarEnginePowers,
              x.CarEnginePower.Number_of_Car_Engine_Powers, x.CarEngine.IdCarEngines, x.CarEngine.Number_of_Car_Engine, x.CarFueltype.IdCarFueltypes, x.CarFueltype.Name_of_Car_Fueltypes,
              x.CarGearbox.IdCarGearboxes, x.CarGearbox.Name_of_Car_Gearboxes, x.CarKilometre.IdCarKilometres, x.CarKilometre.Number_of_Car_Kilometres, x.CarPrice.IdCarPrices, x.CarPrice.Number_of_Car_Prices,
              x.CarQuantity.IdCarQuantities, x.CarQuantity.Quantity_of_Car, x.CarTransmission.IdCarTransmissions, x.CarTransmission.Name_of_Car_Transmissions, x.ManufactureYear.IdManufactureYears, x.ManufactureYear.Manufacture_Years,
              x.NewCar.IdNewCars, x.NewCar.New_Car}).Select(x => x.First()).Distinct();
 
            return ObservableCollectionHelper.ToObservableCollection(cars);
        }

        public void AddData(Car data)
        {
            CarDataContext.Cars.InsertOnSubmit(data);

            CarDataContext.SubmitChanges();
        }

        public void UpdateData(Car data)
        {

            //var car = CarDataContext.Cars.Single(u => u.IdCars == GetData(data.IdCars).IdCars);

            var car = GetData(data.IdCars);

            car = data;


            CarDataContext.SubmitChanges();
        }

        public void DeleteData(Car data)
        {
          //  CarDataContext.Cars.Attach(data);
            CarDataContext.Cars.DeleteOnSubmit(data);
            CarDataContext.SubmitChanges();
        }
    }
}
