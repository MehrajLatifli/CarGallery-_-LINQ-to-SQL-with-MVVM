﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Models.Abstraction
{
    public interface IRepository<T>
    {
        T GetData(int id);

        ObservableCollection<T> GetAllData();

        void AddData(T data);

        void UpdateData(T data);

        void DeleteData(T data);
    }
}
