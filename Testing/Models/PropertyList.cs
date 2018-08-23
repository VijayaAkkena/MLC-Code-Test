using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MLC.Web.Models
{
    public class PropertyOwnerList
    {
        [Display(Name = "Owner Name")]
        public string Name { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }
        public string Age { get; set; }
        public List<Property> Properties { get; set; }

        [Display(Name = "Property Name")]
        public string PropertyName { get; set; }

        [Display(Name = "Property Type")]
        public string PropertyType { get; set; }
    }
    public class Property
    {
        [Display(Name = "Property Name")]
        public string Name { get; set; }

        [Display(Name = "Property Type")]
        public string Type { get; set; }
    }
}