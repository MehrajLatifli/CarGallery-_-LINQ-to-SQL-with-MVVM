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
    public class CarColorsRepository : ICarColorsRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public CarColorsRepository()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public CarColor GetData(int id)
        {
            var c = DataContext.CarColors.FirstOrDefault(x => x.IdCarColors == id);

            return c;

        }

        public ObservableCollection<CarColor> GetAllData()
        {
            var c = DataContext.CarColors.GroupBy(x => x.Name_of_Car_Color).Select(x => x.First()).Distinct();

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(CarColor data)
        {
            DataContext.CarColors.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(CarColor data)
        {
            //var c = GetData(data.IdCarColors);

            //c = data;

            //DataContext.SubmitChanges();
        }

        public void DeleteData(CarColor data)
        {
            DataContext.CarColors.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
