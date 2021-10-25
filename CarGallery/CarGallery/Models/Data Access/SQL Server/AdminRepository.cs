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
    class AdminRepository : IAdminRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public AdminRepository()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public Admin GetData(int id)
        {
            var admin = DataContext.Admins.FirstOrDefault(c => c.IdAdmins == id);



            return admin;

        }

        public ObservableCollection<Admin> GetAllData()
        {
            var admin = from b in DataContext.Admins select b;

            return ObservableCollectionHelper.ToObservableCollection(admin);
        }

        public void AddData(Admin data)
        {
            DataContext.Admins.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(Admin data)
        {
            var admin = GetData(data.IdAdmins);

            admin = data;


            DataContext.SubmitChanges();
        }

        public void DeleteData(Admin data)
        {
            DataContext.Admins.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
