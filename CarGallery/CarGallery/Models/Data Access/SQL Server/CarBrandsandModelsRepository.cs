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
    public class CarBrandsandModelsRepository : ICarBrandsandModelsRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public CarBrandsandModelsRepository()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public CarBrandsandModel GetData(int id)
        {
            var c = DataContext.CarBrandsandModels.FirstOrDefault(x => x.IdCarBrandsandModels == id);

            return c;

        }

        public ObservableCollection<CarBrandsandModel> GetAllData()
        {

            var c = DataContext.CarBrandsandModels.GroupBy(x => new { x.BrandsandModels_of_car, x.Images_of_car }).Select(x => x.First()).Distinct();

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(CarBrandsandModel data)
        {
            DataContext.CarBrandsandModels.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(CarBrandsandModel data)
        {
            //var c = GetData(data.IdCarBrandsandModels);

            //c = data;

            //DataContext.SubmitChanges();
        }

        public void DeleteData(CarBrandsandModel data)
        {
            DataContext.CarBrandsandModels.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
