using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Models.Additional_Classes
{
   public class ComboBoxSelect
    {
        public ObservableCollection<Position> ComboBoxGetAll()
        {
            return new ObservableCollection<Position>
            {
                new Position
                {
                    PositionName="Admin"
                },
                new Position
                {
                    PositionName="Customer"
                },
            };
        }
    }
}
