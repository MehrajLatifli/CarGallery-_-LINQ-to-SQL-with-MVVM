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
    public class CarPrisesRepositorycs : ICarPricesRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public CarPrisesRepositorycs()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public CarPrice GetData(int id)
        {
            var c = DataContext.CarPrices.FirstOrDefault(x => x.IdCarPrices == id);

            return c;

        }

        public ObservableCollection<CarPrice> GetAllData()
        {
            var c = DataContext.CarPrices.GroupBy(x => x.Number_of_Car_Prices).Select(x => x.First()).Distinct();

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(CarPrice data)
        {
            DataContext.CarPrices.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(CarPrice data)
        {
            //var c = GetData(data.IdCarPrices);

            //c = data;

            //DataContext.SubmitChanges();
        }

        public void DeleteData(CarPrice data)
        {
            DataContext.CarPrices.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
