using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vn.com.BTap4_21520739.Models;

namespace vn.com.BTap4_21520739.Controllers
{
    public class CatalogController : Controller
    {
        string connectionString = "Data Source=LAPTOP-9J86UH5O\\SQLEXPRESS;Initial Catalog=QuanLySanPham;Integrated Security=True;Encrypt=False";
        // GET: Catalog
        public ActionResult Index()
        {
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext(connectionString);
            List<Catalog> dsCatalog = context.Catalogs.ToList();
            return View(dsCatalog);
        }
    }
}