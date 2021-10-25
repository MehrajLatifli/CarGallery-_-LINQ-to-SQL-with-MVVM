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
    public class CarEnginesRepository : ICarEnginesRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public CarEnginesRepository()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public CarEngine GetData(int id)
        {
            var c = DataContext.CarEngines.FirstOrDefault(x => x.IdCarEngines == id);

            return c;

        }

        public ObservableCollection<CarEngine> GetAllData()
        {
            var c = DataContext.CarEngines.GroupBy(x => x.Number_of_Car_Engine).Select(x => x.First()).Distinct();

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(CarEngine data)
        {
            DataContext.CarEngines.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(CarEngine data)
        {
            //var c = GetData(data.IdCarEngines);

            //c = data;

            //DataContext.SubmitChanges();
        }

        public void DeleteData(CarEngine data)
        {
            DataContext.CarEngines.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
