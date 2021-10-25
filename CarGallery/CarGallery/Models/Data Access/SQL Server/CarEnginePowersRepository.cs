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
    public class CarEnginePowersRepository : ICarEnginePowersRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public CarEnginePowersRepository()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public CarEnginePower GetData(int id)
        {
            var c = DataContext.CarEnginePowers.FirstOrDefault(x => x.IdCarEnginePowers == id);

            return c;

        }

        public ObservableCollection<CarEnginePower> GetAllData()
        {
            var c = DataContext.CarEnginePowers.GroupBy(x => x.Number_of_Car_Engine_Powers).Select(x => x.First()).Distinct();

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(CarEnginePower data)
        {
            DataContext.CarEnginePowers.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(CarEnginePower data)
        {
            //var c = GetData(data.IdCarEnginePowers);

            //c = data;

            //DataContext.SubmitChanges();
        }

        public void DeleteData(CarEnginePower data)
        {
            DataContext.CarEnginePowers.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
