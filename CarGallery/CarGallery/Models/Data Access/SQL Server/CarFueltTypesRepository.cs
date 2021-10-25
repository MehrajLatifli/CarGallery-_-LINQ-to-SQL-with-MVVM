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
    public class CarFueltTypesRepository : ICarFueltypesRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public CarFueltTypesRepository()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public CarFueltype GetData(int id)
        {
            var c = DataContext.CarFueltypes.FirstOrDefault(x => x.IdCarFueltypes == id);

            return c;

        }

        public ObservableCollection<CarFueltype> GetAllData()
        {
            var c = DataContext.CarFueltypes.GroupBy(x => x.Name_of_Car_Fueltypes).Select(x => x.First()).Distinct();

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(CarFueltype data)
        {
            DataContext.CarFueltypes.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(CarFueltype data)
        {
            //var c = GetData(data.IdCarFueltypes);

            //c = data;

            //DataContext.SubmitChanges();
        }

        public void DeleteData(CarFueltype data)
        {
            DataContext.CarFueltypes.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
