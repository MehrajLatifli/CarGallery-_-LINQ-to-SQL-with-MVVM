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
    public class CarQuantitiesRepository : ICarQuantitesRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public CarQuantitiesRepository()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public CarQuantity GetData(int id)
        {
            var c = DataContext.CarQuantities.FirstOrDefault(x => x.IdCarQuantities == id);

            return c;

        }

        public ObservableCollection<CarQuantity> GetAllData()
        {
            var c = DataContext.CarQuantities.GroupBy(x => x.Quantity_of_Car).Select(x => x.First()).Distinct();

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(CarQuantity data)
        {
            DataContext.CarQuantities.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(CarQuantity data)
        {
            //var c = GetData(data.IdCarQuantities);

            //c = data;

            //DataContext.SubmitChanges();
        }

        public void DeleteData(CarQuantity data)
        {
            DataContext.CarQuantities.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
