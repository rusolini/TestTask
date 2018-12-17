using Dropdownlistmvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dropdownlistmvc.Service
{
    public interface IDish
    {
        IList<Dish> GetDishs { get; }
        void Save(Dish employee);
        void Delete(int? Id);

        Dish GetDish(int? Id);
    }
}