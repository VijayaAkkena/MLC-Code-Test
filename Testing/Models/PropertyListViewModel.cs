using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MLC.Web.Models
{
    public class PropertyListViewModel
    {
        public List<PropertyOwnerList> PropertyList { get; set; }

        [Display(Name ="Gender")]
        public string Gender { get; set; }
        [Display(Name = "Property Type")]

        public string PropertyType { get; set; }
    }


}