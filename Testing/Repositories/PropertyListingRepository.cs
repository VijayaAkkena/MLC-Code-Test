using MLC.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using MLC.Web.Repositories;

namespace MLC.Web.Repositories
{
    public class PropertyListingRepository : IPropertyListingRepository
    {
        List<PropertyOwnerList> propertiesDomainModel = null;
        public PropertyListingRepository()
        {
             
        }

        public List<PropertyOwnerList> GetProperties(string filePath)
        {
            var propertyOwners = new List<PropertyOwnerList>();
            propertiesDomainModel = new List<PropertyOwnerList>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                propertyOwners = JsonConvert.DeserializeObject<List<PropertyOwnerList>>(json);
            }

            foreach (var owner in propertyOwners)
            {
                var item = new PropertyOwnerList
                {
                    Name = owner.Name,
                    Age = owner.Age,
                    Gender = owner.Gender
                };
                var added = false;
                if (owner.Properties != null)
                {
                    foreach (var property in owner.Properties)
                    {
                        item.PropertyName = property.Name;
                        item.PropertyType = property.Type;
                    }
                    propertiesDomainModel.Add(item);
                    added = true;
                }
                if (!added) { propertiesDomainModel.Add(item); }

            }

            return propertiesDomainModel;
            
        }
    }
}