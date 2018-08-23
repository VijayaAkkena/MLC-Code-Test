using MLC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLC.Web.Repositories
{
   public interface IPropertyListingRepository
    {
        List<PropertyOwnerList> GetProperties(string filePath);
    }
}
