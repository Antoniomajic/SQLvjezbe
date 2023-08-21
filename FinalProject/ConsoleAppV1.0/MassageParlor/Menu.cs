using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MassageParlor
{
    internal class Menu
    {
        public ControllerCustomer ControllerCustomer { get; }
        public ControllerAppointment ControllerAppointment;
        public ControllerMassage ControllerMassage { get; }
        public ControllerAppointmentMassage ControllerAppointmentMassage { get; }
        public ControllerAppointmentMassage AppointmentMassage { get; }

        

        public Menu() // constructor
        {
            ControllerCustomer = new ControllerCustomer();
            ControllerAppointment = new ControllerAppointment(this);
            ControllerMassage = new ControllerMassage();
            ControllerAppointmentMassage = new ControllerAppointmentMassage();
            
            HelloMessage();
            ShowMenu();
        }

        private void HelloMessage()
        {
            Console.WriteLine("**********************************"); // 34 characters
            Console.WriteLine("*** Massage Parlor Console App ***");

        }


        private void ShowMenu()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("             Main menu            ");
            Console.WriteLine("**********************************");
            Console.WriteLine("          1. Customer             ");
            Console.WriteLine("          2. Appointment          ");
            Console.WriteLine("          3. Massage              ");
            Console.WriteLine("          4. App-Massage          ");
            Console.WriteLine("          5. Exit the program     ");

            switch(Supplementary.LoadNumberRange("Select menu option: ", "Please select option number (1-5)!",1,5))
            {
                case 1:
                    ControllerCustomer.ShowMenu();
                    ShowMenu();
                    break;
                case 2:
                    ControllerAppointment.ShowMenu();
                    ShowMenu();
                    break;
                case 3:
                    ControllerMassage.ShowMenu();
                    ShowMenu();
                    break;
                case 4:
                    ControllerAppointmentMassage.ShowMenu();
                    ShowMenu();
                    break;
                case 5:
                    Console.WriteLine("Thank you for using this app! Goodbye!\n**************************************");                    
                    break;
            }
            


        }



    }
}
