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

    public class CustomerRepository : ICustomerRepository
    {
        public CarGalleryDataClassesDataContext DataContext { get; set; }

        public CustomerRepository()
        {
            DataContext = new CarGalleryDataClassesDataContext();
        }

        public Customer GetData(int id)
        {
            var customer = DataContext.Customers.FirstOrDefault(c => c.IdCustomers == id);



            return customer;

        }

        public ObservableCollection<Customer> GetAllData()
        {
            var c = from b in DataContext.Customers select b;

            return ObservableCollectionHelper.ToObservableCollection(c);
        }

        public void AddData(Customer data)
        {
            DataContext.Customers.InsertOnSubmit(data);

            DataContext.SubmitChanges();
        }

        public void UpdateData(Customer data)
        {
            //var car = GetData(data.IdCustomers);

            //car = data;


            //DataContext.SubmitChanges();
        }

        public void DeleteData(Customer data)
        {
            DataContext.Customers.DeleteOnSubmit(data);
            DataContext.SubmitChanges();
        }
    }
}
