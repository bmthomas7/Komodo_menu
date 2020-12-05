using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Menu_console
{
    class ProgramUI
    {
        private DevContentRepository _ContentRepo = new DevContentRepository();

        public void run()
        {
            seedContentList();
            Menu();

        }

        private void Menu()
        {
            bool KeepRunning = true;
            while (KeepRunning)
            {


                //Display our options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Menu Item\n" +
                    "2. View Menu\n" +
                    "3. View Content By Menu item\n" +
                    "4. Update Existing Menu Item's\n" +
                    "5. Delete Existing Menu Item's\n" +
                    "6. Exit");

                //Get the user's input
                string input = Console.ReadLine();

                //Evaluate the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        //create new content
                        CreateNewContent();
                        break;
                    case "2":
                        //view all content
                        DisplayAllContent();
                        break;
                    case "3":
                        //view content by title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        //update existing content
                        UpdateExistingContent();
                        break;
                    case "5":
                        //delete existing content
                        DeleteExistingContent();
                        break;
                    case "6":
                        //exit
                        Console.WriteLine("Goodbye!");
                        KeepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Pleasr press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void CreateNewContent()
        {
            DevMenu newContent = new DevMenu();

        }



    }
}
