using BLL;
using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TierApp1.Controllers
{
    public class ProductController : ApiController
    {
        [Route("api/Product/All")]
        [HttpGet]
        public List<ProductModel> GetAll()
        {
            return ProductService.GetAll();
        }
        [Route("api/Product/Names")]
        [HttpGet]
        public List<string> Names()
        {
            return ProductService.GetNames();
        }
    }
}
