using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MassageParlor
{
    internal class ControllerAppointment
    {

        public List<Appointment> Appointments { get; }
        


        private Menu Menu;

        public ControllerAppointment()
        {
            Appointments = new List<Appointment>();
            if (Supplementary.DEV)
            {
                TestData();
            }

        }

        public ControllerAppointment(Menu menu) : this()
        {
            this.Menu = menu;
        }



        public void ShowMenu() // Appointment Menu
        {
            Console.WriteLine();
            Console.WriteLine("******** Appointment menu ********");
            Console.WriteLine("1. Show appointments");
            Console.WriteLine("2. Create new appointment");
            Console.WriteLine("3. Edit appointment");
            Console.WriteLine("4. Delete appointment");
            Console.WriteLine("5. Return to main menu");

            switch (Supplementary.LoadNumberRange("Select appointment menu option: ", "Please select option number (1-5)!", 1, 5))
            {
                case 1:
                    ShowAppointments();
                    ShowMenu();
                    break;
                case 2:
                    CreateNewAppointment();
                   
                    ShowMenu();
                    break;
                case 3:
                    EditAppointment();
                    ShowMenu();
                    break;
                case 4:
                    if (Appointments.Count == 0)
                    {
                        Console.WriteLine("No appointments to delete!");
                    }
                    else
                    {
                        DeletingAppointment();
                    }
                    ShowMenu();
                    break;
                case 5:
                    Console.WriteLine("Finish working with appointments");
                    break;
            }

        }

        private void DeletingAppointment()
        {
            Console.WriteLine();
            ShowAppointments();
            int index = Supplementary.LoadNumberRange("Choose ordinal number of appointment to delete: ", "Not good choice!", 1, Appointments.Count());
            Appointments.RemoveAt(index - 1);
        }

        private void EditAppointment()
        {
            Console.WriteLine();
            ShowAppointments();
            int index = Supplementary.LoadNumberRange("Select ordinal number of appointment: ", "You did not enter existing appointment!", 1, Appointments.Count());
            var a = Appointments[index - 1];
            a.ID = Supplementary.LoadWholeNumber("Input ID of appointment (" + a.ID + "): ", "Error");
            a.DateAndTime = Supplementary.LoadDate("Input date of the appointment in the following format: dd.mm.yyyy.", "Error");
            Console.WriteLine("Current customers: {0}", a.Customer.FirstName + a.Customer.LastName);
            a.Customer = AddCustomer();
            
        }

        public void CreateNewAppointment()
        {
            Console.WriteLine();
            var a = new Appointment();
            a.ID = Supplementary.LoadWholeNumber("Input ID of appointment: ", "Input has to be whole positive number!");
            a.DateAndTime = Supplementary.LoadDate("Input date of the appointment in the following format: dd.mm.yyyy.: ", "Error");
            a.Customer = AddCustomer();
            Appointments.Add(a);
        }



        public void ShowAppointments()
        {
            Console.WriteLine();
            Console.WriteLine("**********************************");
            Console.WriteLine("******** Appointments list *******");
            int n = 1;
            foreach (Appointment appointment in Appointments)
            {
                Console.WriteLine("\t{0}. {1}", n++, appointment.DateAndTime + " " + appointment.Customer.FirstName + " " + appointment.Customer.LastName);
            }
            Console.WriteLine("**********************************");
        }

        private Customer AddCustomer()
        {
            Console.WriteLine();
            Menu.ControllerCustomer.ShowCustomers();
            int index = Supplementary.LoadNumberRange("Select ordinal number of customer: ", "You did not select customer number!", 1, Menu.ControllerCustomer.Customers.Count());
            return Menu.ControllerCustomer.Customers[index - 1];
        }

        private void TestData()
        {

        }
        
    }
}
