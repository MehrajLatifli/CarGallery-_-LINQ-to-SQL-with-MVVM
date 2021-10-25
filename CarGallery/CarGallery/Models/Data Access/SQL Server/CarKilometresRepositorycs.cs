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
    public class CarKilometresRepositorycs : ICarKilometresRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public CarKilometresRepositorycs()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public CarKilometre GetData(int id)
        {
            var c = DataContext.CarKilometres.FirstOrDefault(x => x.IdCarKilometres == id);

            return c;

        }

        public ObservableCollection<CarKilometre> GetAllData()
        {
            var c = DataContext.CarKilometres.GroupBy(x => x.Number_of_Car_Kilometres).Select(x => x.First()).Distinct();

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(CarKilometre data)
        {
            DataContext.CarKilometres.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(CarKilometre data)
        {
            //var c = GetData(data.IdCarKilometres);

            //c = data;

            //DataContext.SubmitChanges();
        }

        public void DeleteData(CarKilometre data)
        {
            DataContext.CarKilometres.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
