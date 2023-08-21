using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MassageParlor
{
    internal class ControllerCustomer
    {

        public List<Customer> Customers { get;}

        public ControllerCustomer()
        {
            Customers = new List<Customer>();
            if (Supplementary.DEV)
            {
                TestData();
            }

        }

        public void ShowMenu() // Customer Menu
        {
            Console.WriteLine("********** Customer menu *********");
            Console.WriteLine("1. Show customers");
            Console.WriteLine("2. Create new customer");
            Console.WriteLine("3. Edit customer");
            Console.WriteLine("4. Delete customer");
            Console.WriteLine("5. Return to main menu");

            switch(Supplementary.LoadNumberRange("Select customer menu option: ", "Please select option number (1-5)!", 1, 5))
            {
                case 1:
                    ShowCustomers();
                    ShowMenu();
                    break;
                case 2:
                    CreateNewCustomer();
                    ShowMenu();
                    break;
                case 3:
                    EditCustomer();
                    ShowMenu();
                    break;
                case 4:
                    if (Customers.Count == 0)
                    {
                        Console.WriteLine("No customers to delete!");
                    }
                    else
                    {
                        DeleteCustomer();
                    }                    
                    ShowMenu();
                    break;
                case 5:
                    Console.WriteLine("Returning back to menu");
                    break;
            }

        }

        private void DeleteCustomer()
        {
            ShowCustomers();
            int number = Supplementary.LoadNumberRange("Select number of Customer to delete: ", "Please select correct ordinal number!", 1, Customers.Count());
            Customers.RemoveAt(number-1);

        }

        private void EditCustomer()
        {
            ShowCustomers();
            int number = Supplementary.LoadNumberRange("Select number of Customer to change: ", "Please select correct ordinal number!", 1, Customers.Count());
            var c = Customers[number-1];
            c.ID = Supplementary.LoadWholeNumber("Add customer ID(" + c.ID+"): ", "ID has to be positive whole number");
            c.FirstName = Supplementary.LoadString("Write the first name(" + c.ID + "): ", "You didn't write the first name!");
            c.LastName = Supplementary.LoadString("Write the last name(" + c.ID + "): ", "You didn't write the last name!");
            c.Contact = Supplementary.LoadString("Write the contact (" + c.ID + "): ", "Obligatory input!");

        }

        public void CreateNewCustomer()
        {
            var c = new Customer();
            c.ID = Supplementary.LoadWholeNumber("Add customer ID", "ID has to be positive whole number");
            c.FirstName = Supplementary.LoadString("Write the first name: ", "You didn't write the first name!");
            c.LastName = Supplementary.LoadString("Write the last name: ", "You didn't write the last name!");
            c.Contact = Supplementary.LoadString("Write the contact (e-mail/telephone): ", "Obligatory input!");
            Customers.Add(c);
        }

        public void ShowCustomers()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("********** Customer list *********");
            int n = 1;
            foreach(Customer customer in Customers)
            {
                Console.WriteLine("\t{0}. {1}",n++,customer.FirstName + " " + customer.LastName);
            }
            Console.WriteLine("**********************************");
        }

        private void TestData()
        {
            Customers.Add(new Customer { FirstName = "Ana" , LastName = "Mitrović"});
        }

        
    }
}
