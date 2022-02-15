using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerExam.Models
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        // GET: api/<ApiController>
        [HttpGet]
        public string Get()
        {
            DBhandle db = new DBhandle();

             List<Customer> listP = db.getAllRecords();
            return JsonConvert.SerializeObject(listP);
            //  return new string[] { "value1", "value2" };
            //return db.getAllRecords();
        }


        // GET api/<ApiController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {

            DBhandle db = new DBhandle();
            return db.getCustomerById(id);
        }
       

        // POST api/<ApiController>
        [HttpPost]
        [Route("register")]
        public void Post(Customer s)
        {
            DBhandle db = new DBhandle();
            db.addCustomer(s);
            return;
        }


        // PUT api/<ApiController>/5
        [HttpPut]

        public void Put(Customer s)
        {
            DBhandle db = new DBhandle();
            db.updateCustomer(s);
            return;
        }


        // DELETE api/<ApiController>/5
        [HttpDelete("{Customer_Id}")]
        public void delete(int Customer_Id)
        {
            DBhandle db = new DBhandle();
            db.deleteCustomer(Customer_Id);
            return;

        }
    }
}
