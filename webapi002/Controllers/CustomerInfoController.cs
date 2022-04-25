using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using webapi002.Data.Model;
using webapi002.Data.Services;
using webapi002.Data.ViewModels;
using System.Data.SqlClient;

namespace webapi002.Controllers
{
    [Route("api/[controller]")] // will add api endpoint : loc:xx/api/controller/api endpoint
    [ApiController] // api or mvc controller 
    public class CustomerDetailsController : ControllerBase
    {
        public CustomerServices _customerService;
        public CustomerDetailsController(CustomerServices customerService)
        {
            _customerService = customerService;
        }
        // our first end point 
        [HttpPost]
        public IActionResult AddCustomer([FromBody] CustomerVm customer)
        {
            _customerService.AddCustomer(customer);
            return Ok();
        }


        [HttpGet("GettingAllCustomers")]
        //[Route("GettingAllData")]
        public IActionResult GetAllCustomers()
        {
            var allCustomers = _customerService.GetAllCustomers();
            return Ok(allCustomers);
        }

        [HttpGet]
        [Route("GettingACustomer /{id}")]
        public IActionResult GetCustomerInfo(int id)
        {
            var customerInfo = _customerService.GetCustomerInfo(id);
            return Ok(customerInfo);
        } 

    }
}
