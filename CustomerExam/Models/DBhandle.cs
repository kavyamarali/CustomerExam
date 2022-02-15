using Newtonsoft.Json;

namespace CustomerExam.Models
{
    public class DBhandle
    {
         public List<Customer> getAllRecords()
       {

           EFDBHandle context = new EFDBHandle(); //base class
           List<Customer> listP = context.Customers.ToList();
            return listP;
       }
        public void addCustomer(Customer s)
        {
            s.Created_Date = DateTime.Now;
            EFDBHandle context = new EFDBHandle();
            context.Customers.Add(s);
            context.SaveChanges();
            return;



        }
        public void deleteCustomer(int Customer_Id)
        {
            EFDBHandle context = new EFDBHandle();

              Customer emp = context.Customers.Find(Customer_Id);
              context.Customers.Remove(emp);

          
            context.SaveChanges();
            return;
        }
        public Customer getEmployeeOnId(int Customer_Id)
        {
            EFDBHandle context = new EFDBHandle();
            var emp = context.Customers.Find(Customer_Id);
            return emp;
        }
        public void updateCustomer(Customer s)
        {
            EFDBHandle context = new EFDBHandle();
            Customer emp = context.Customers.Find(s.Customer_Id);
            emp.First_Name = s.First_Name;
            emp.Last_Name = s.Last_Name;
            emp.Country = s.Country;
            emp.Created_Date = s.Created_Date;
           
            context.SaveChanges();
            return;
        }
        public Customer getCustomerById(int Customer_Id)
        {
            EFDBHandle context = new EFDBHandle();
            return context.Customers.Find(Customer_Id);
        }

    }
}
