using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Api.Models;
using Api.Services;


namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {F        ProductService _productService;
        public ProductController(ProductService productService)
        {
            this._productService = productService;    
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this._productService.GetProducts());
        }

        [HttpPost]
        public ActionResult Post(Products products)
        {
            this._productService.AddProduct(products);
            return Ok();
        }       

    }
}