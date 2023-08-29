using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageParlor
{
    internal class ControllerMassage
    {
        public List<Massage> Massages { get; }

        public ControllerMassage()
        {
            Massages = new List<Massage>();
            if (Supplementary.DEV)
            {
                //TestData();
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("********** Massage menu *********");
            Console.WriteLine("1. Show massages");
            Console.WriteLine("2. Create new massage");
            Console.WriteLine("3. Edit massage");
            Console.WriteLine("4. Delete Massage");
            Console.WriteLine("5. Return to main menu");

            switch(Supplementary.LoadNumberRange("Select massage menu option: ", "Please select option number (1-5)!", 1, 5))
            {
                case 1:
                    ShowMassages();
                    ShowMenu();
                    break;
                case 2:
                    CreateNewMassage();
                    ShowMenu(); 
                    break;
                case 3:
                    EditMassage();
                    ShowMenu(); 
                    break;
                case 4:
                    if(Massages.Count == 0)
                    {
                        Console.WriteLine("No massages to delete!");
                    }
                    else
                    {
                        DeleteMassage();
                    }
                    ShowMenu();
                    break;
                case 5:
                    Console.WriteLine("Returning to the main menu");
                    break;

            }


        }

        private void DeleteMassage()
        {
            ShowMassages();
            int number = Supplementary.LoadNumberRange("Select number of Massage to delete: ", "Please select correct ordinal number!", 1, Massages.Count());
            Massages.RemoveAt(number-1);
        }

        private void EditMassage()
        {
            ShowMassages();
            int number = Supplementary.LoadNumberRange("Select number of Massage to change: ", "Please select correct ordinal number!", 1, Massages.Count());
            var m = Massages[number - 1];
            m.ID = Supplementary.LoadWholeNumber("Add customer ID(" + m.ID + "): ", "ID has to be positive whole number");
            m.Name = Supplementary.LoadString("Give name to massage: ", "Error");
            m.Description = Supplementary.LoadString("Describe the massage: ", "Error");
            m.Duration = Supplementary.LoadWholeNumber("Type how long will massage last (in minutes): ", "Error");
            m.Price = Supplementary.LoadDecimalNumber("Insert the price (decimal): ", "Price must be in decimal format example: 10.99");
        }

        public void CreateNewMassage()
        {
            var m=new Massage();
            m.ID = Supplementary.LoadWholeNumber("Add massage ID", "ID has to be positive whole number");
            m.Name = Supplementary.LoadString("Write the name of the massage: ", "Error");
            m.Description = Supplementary.LoadString("Describe the massage: ", "Error");
            m.Duration = Supplementary.LoadWholeNumber("How long does the massage last (in minutes)?: ", "Type in whole number!");
            m.Price = Supplementary.LoadDecimalNumber("Input the price: ", "Price must be in decimal format example: 10.99");
            Massages.Add(m);
        }

        public void ShowMassages()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("********** Massage list **********");
            int n = 1;
            foreach(Massage massage in Massages)
            {
                Console.WriteLine("\t{0}. {1}",n++, massage.Name);
            }
            Console.WriteLine("**********************************");
        }
    }
}
