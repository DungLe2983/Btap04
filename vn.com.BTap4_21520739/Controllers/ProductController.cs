using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vn.com.BTap4_21520739.Models;

namespace vn.com.BTap4_21520739.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        string connectionString = "Data Source=LAPTOP-9J86UH5O\\SQLEXPRESS;Initial Catalog=QuanLySanPham;Integrated Security=True;Encrypt=False";
        public ActionResult Index()
        {
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext(connectionString);
            List<Product> dsProduct = context.Products.ToList();
            return View(dsProduct);
        }
    }
}