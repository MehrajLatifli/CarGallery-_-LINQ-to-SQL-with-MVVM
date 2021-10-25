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
    public class NewCarsRepository : INewCarsRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public NewCarsRepository()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public NewCar GetData(int id)
        {
            var c = DataContext.NewCars.FirstOrDefault(x => x.IdNewCars == id);

            return c;

        }

        public ObservableCollection<NewCar> GetAllData()
        {
            var c = DataContext.NewCars.GroupBy(x => x.New_Car).Select(x => x.First()).Distinct();

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(NewCar data)
        {
            DataContext.NewCars.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(NewCar data)
        {
            //var c = GetData(data.IdNewCars);

            //c = data;

            //DataContext.SubmitChanges();
        }

        public void DeleteData(NewCar data)
        {
            DataContext.NewCars.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
