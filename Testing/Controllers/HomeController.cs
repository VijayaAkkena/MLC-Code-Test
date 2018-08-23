using MLC.Web.Models;
using MLC.Web.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
 

namespace MLC.Web.Controllers
{
    public class HomeController : Controller
    {
        const string FilePath = @"/Data/PropertyList.JSON";
        IPropertyListingRepository _propertyRepo;
        PropertyListViewModel viewModel = null;
        public HomeController()
        {
            _propertyRepo = new PropertyListingRepository();
        }
        public ActionResult Index()
        {
            string path = Server.MapPath(FilePath);
            
            var domainModel = _propertyRepo.GetProperties(path);

            domainModel = domainModel?.Where(x => x.PropertyName != null).
                                OrderBy(li => li.PropertyName).ToList();

            viewModel = new PropertyListViewModel();
            viewModel.PropertyList = domainModel;
            TempData["MasterData"] = viewModel;

            return View(viewModel);
        }
        

        [HttpPost]
        public ActionResult Index(string propertyType)
        {
            var data = TempData["MasterData"] as PropertyListViewModel;
            TempData.Keep();

            var viewModel = new PropertyListViewModel();
            if(propertyType.ToLower().Equals("all"))
            {
                viewModel.PropertyList = data.PropertyList.OrderBy(x => x.PropertyName).ToList();

            }
            else
            {
                viewModel.PropertyList = data.PropertyList.Where(x => x.PropertyType == propertyType).OrderBy(x => x.PropertyName).ToList();
            }
            
             
            return PartialView("_PropertyListing", viewModel);

           
        }

       
    }
}