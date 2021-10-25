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
    public class CarGearBoxesRepositorycs : ICarGearBoxesRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public CarGearBoxesRepositorycs()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public CarGearbox GetData(int id)
        {
            var c = DataContext.CarGearboxes.FirstOrDefault(x => x.IdCarGearboxes == id);

            return c;

        }

        public ObservableCollection<CarGearbox> GetAllData()
        {
            var c = DataContext.CarGearboxes.GroupBy(x => x.Name_of_Car_Gearboxes).Select(x => x.First()).Distinct();

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(CarGearbox data)
        {
            DataContext.CarGearboxes.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(CarGearbox data)
        {
            //var c = GetData(data.IdCarGearboxes);

            //c = data;

            //DataContext.SubmitChanges();
        }

        public void DeleteData(CarGearbox data)
        {
            DataContext.CarGearboxes.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
