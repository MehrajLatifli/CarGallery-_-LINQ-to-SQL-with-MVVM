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
    public class CarBodyStyllesRepository :ICarBodyStylesRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public CarBodyStyllesRepository()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public CarBodyStyle GetData(int id)
        {
            var c = DataContext.CarBodyStyles.FirstOrDefault(x => x.IdCarBodyStyles == id);

            return c;

        }

        public ObservableCollection<CarBodyStyle> GetAllData()
        {
            var c = DataContext.CarBodyStyles.GroupBy(x => x.Name_of_Car_Body_Styles).Select(x => x.First()).Distinct();

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(CarBodyStyle data)
        {
            DataContext.CarBodyStyles.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(CarBodyStyle data)
        {
            //var c = GetData(data.IdCarBodyStyles);

            //c = data;

            //DataContext.SubmitChanges();
        }

        public void DeleteData(CarBodyStyle data)
        {
            DataContext.CarBodyStyles.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
