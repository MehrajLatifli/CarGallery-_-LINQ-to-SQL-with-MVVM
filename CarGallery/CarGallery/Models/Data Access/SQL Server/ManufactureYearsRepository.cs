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
    public class ManufactureYearsRepository : IManufactureYearsRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public ManufactureYearsRepository()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public ManufactureYear GetData(int id)
        {
            var c = DataContext.ManufactureYears.FirstOrDefault(x => x.IdManufactureYears == id);

            return c;

        }

        public ObservableCollection<ManufactureYear> GetAllData()
        {
            var c = DataContext.ManufactureYears.GroupBy(x => x.Manufacture_Years).Select(x => x.First()).Distinct();

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(ManufactureYear data)
        {
            DataContext.ManufactureYears.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(ManufactureYear data)
        {
            //var c = GetData(data.IdManufactureYears);

            //c = data;

            //DataContext.SubmitChanges();
        }

        public void DeleteData(ManufactureYear data)
        {
            DataContext.ManufactureYears.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
