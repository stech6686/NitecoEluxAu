using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elux.ApiIntergration.EluxPim;

namespace Elux.ApiIntergration
{
    public static class EluxApiIntHelper
    {
        public static EluxPim.CategoryEntity GetCategory()
        {
            return new CategoryEntity
            {
                SubCategory = new CategoryEntity[] { new CategoryEntity { }, }
            };
        }
    }
}
