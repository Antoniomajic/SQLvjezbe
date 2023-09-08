using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageParlor
{
    internal class ControllerAppointmentMassage
    {
        public List<AppointmentMassage> AppointmentMassages { get;}

        private Menu Menu;

        public ControllerAppointmentMassage()
        {
            AppointmentMassages = new List<AppointmentMassage>();
        }

        public ControllerAppointmentMassage(Menu menu) : this()
        {
            this.Menu = menu;
        }

        public void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("********** AppMass menu *********");
            Console.WriteLine("1. Show AppMass");
            Console.WriteLine("2. Create new AppMass");
            Console.WriteLine("3. Edit AppMass");
            Console.WriteLine("4. Delete AppMass");
            Console.WriteLine("5. Return to main menu");

            switch(Supplementary.LoadNumberRange("Select AppMass menu option: ", "Please select option number (1-5)!",1,5))
            {
                case 1:
                    ShowAppMass();
                    ShowMenu();
                    break;
                case 2:
                    CreateNewAppMass();
                    ShowMenu(); 
                    break;
                case 3:
                    EditAppMass();
                    ShowMenu();
                    break;
                case 4:
                    if(AppointmentMassages.Count == 0)
                    {
                        Console.WriteLine("No AppMass to delete!");
                    }
                    else
                    {
                        DeleteAppMass();
                    }
                    ShowMenu();
                    break;
                case 5:
                    Console.WriteLine("Finish working with appointments");
                    break;
            }

        }

        private void DeleteAppMass()
        {
            Console.WriteLine();
            ShowAppMass();
            int index = Supplementary.LoadNumberRange("Select number of appointment_massage to delete: ", "You did not choose existing appointment_massage!", 1, AppointmentMassages.Count());
            AppointmentMassages.RemoveAt(index-1);
        }

        private void EditAppMass()
        {
            Console.WriteLine();
            ShowAppMass();
            int number = Supplementary.LoadNumberRange("Select number of AppMass to change: ", "Please select correct ordinal number!", 1, AppointmentMassages.Count());
            var am = AppointmentMassages[number-1];
            am.ID = Supplementary.LoadWholeNumber("Add AppMass ID(" + am.ID + "): ", "ID has to be positive whole number");
            Console.WriteLine("Current appointments: {0}",am.Appointment.DateAndTime + " " + am.Appointment.Customer.FirstName + " " + am.Appointment.Customer.LastName);
            am.Appointment = AddAppointment();
            Console.WriteLine("Current massages: {0}", am.Massage.Name);
            am.Massage = AddMassage();
            am.Quantity= Supplementary.LoadWholeNumber("Add quantity: ", "Quantity number must be whole positive number!");
        }

        private void CreateNewAppMass()
        {
            Console.WriteLine();
            var am = new AppointmentMassage();
            am.ID = Supplementary.LoadWholeNumber("Input ID of appointment_massage: ", "Input has to be whole positive number!");
            am.Quantity = Supplementary.LoadWholeNumber("Input quantity: ", "Quantity number must be whole positive number!");
            am.Massage = AddMassage();
            am.Appointment = AddAppointment();
            AppointmentMassages.Add(am);

        }

        private void ShowAppMass()
        {
            Console.WriteLine();
            Console.WriteLine("**********************************");
            Console.WriteLine("********** AppMass list **********");
            int n = 1;
            foreach(AppointmentMassage appmass in AppointmentMassages)
            {
                Console.WriteLine("\t{0}. {1}",n++, appmass.Massage.Name + " " + appmass.Appointment.DateAndTime);
            }
            Console.WriteLine("**********************************");
        }

        private Massage AddMassage()
        {
            Console.WriteLine();
            Menu.ControllerMassage.ShowMassages();
            int index = Supplementary.LoadNumberRange("Select ordinal number of massage: ", "You did not select massage number!", 1, Menu.ControllerMassage.Massages.Count());
            return Menu.ControllerMassage.Massages[index-1];
        }

        private Appointment AddAppointment()
        {
            Console.WriteLine();
            Menu.ControllerAppointment.ShowAppointments();
            int index = Supplementary.LoadNumberRange("Select ordinal number of appointments: ", "You did not select appointment number!", 1, Menu.ControllerAppointment.Appointments.Count());
            return Menu.ControllerAppointment.Appointments[index-1];
        }
    }
}
