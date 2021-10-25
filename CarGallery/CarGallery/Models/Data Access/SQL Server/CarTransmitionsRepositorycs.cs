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
    public class CarTransmitionsRepositorycs : ICarTransmitionsRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public CarTransmitionsRepositorycs()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public CarTransmission GetData(int id)
        {
            var c = DataContext.CarTransmissions.FirstOrDefault(x => x.IdCarTransmissions == id);

            return c;

        }

        public ObservableCollection<CarTransmission> GetAllData()
        {
            var c = DataContext.CarTransmissions.GroupBy(x => x.Name_of_Car_Transmissions).Select(x => x.First()).Distinct();

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(CarTransmission data)
        {
            DataContext.CarTransmissions.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(CarTransmission data)
        {
            //var c = GetData(data.IdCarTransmissions);

            //c = data;

            //DataContext.SubmitChanges();
        }

        public void DeleteData(CarTransmission data)
        {
            DataContext.CarTransmissions.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
