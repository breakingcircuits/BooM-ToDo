using System;
using System.Collections.Generic;

namespace BoomLibrary
{
    public class Menu
    {
        // Fields & Properties.
        List<User> users = new List<User>();
        bool runMenu = true;

        // Methods.
        public void StartMenu()
        {
            // Menuloop.
            while (runMenu)
            {
                int userMenuChoice = 0;

                Console.Clear();
                Console.WriteLine("Välkommen till Boom GTD."
                                + "\nGör ett sifferval:"
                                + "\n1. Skapa ny användare."
                                + "\n2. Välj en befintlig användare."
                                + "\n3. Avsluta Programmet.");
                try
                {
                    userMenuChoice = Convert.ToInt32(Console.ReadLine());
                    switch (userMenuChoice)
                    {
                        // Create new user.
                        case 1:
                            CreateNewUser();
                            break;
                        
                        // Choose existing user.
                        case 2:
                            ChooseExistingUser();
                            break;

                        // Quit the program.
                        case 3:
                            runMenu = false;
                            break;

                        // Faulty menu selection.
                        default:
                            Console.WriteLine("Felaktigt val. Välj en siffra mellan 1 & 3.");
                            Console.ReadLine();
                            break;
                    }
                }

                // Exception handling for menu.
                catch (FormatException)
                {
                    Console.WriteLine("Du behöver skriva in en siffra.");
                    Console.ReadLine();
                }
                catch (Exception unexpected)
                {
                    Console.WriteLine($"Oväntat fel: {unexpected}");
                    Console.ReadLine();
                }
            }
        }

        // The StartMenu() selection "Create new user".
        public void CreateNewUser()
        {
            Console.Clear();
            Console.WriteLine("Välj ett användarnamn:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Välj ett lösenord till {userName}:");
            string userPassword = Console.ReadLine();

            User newUser = new User(userName, userPassword);
            bool inputNotOk = String.IsNullOrEmpty(userName);
            if (inputNotOk) { CreateNewUser(); }
            else { UserLoggedInMenu(newUser); }
        }

        // The StartMenu() selection "Choose existing user".
        public void ChooseExistingUser()
        {
            Console.WriteLine("Välj en användare med sifferval:\n");
            int indexPos = 0;
            foreach (User user in users)
            {
                Console.WriteLine($"{indexPos + 1}. : {user.UserName}");
            }

            // Exception handling.
            try
            {
                int userSelect = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Skriv in en siffra.");
                Console.ReadLine();
            }
            catch (Exception unexpected)
            {
                Console.WriteLine($"Oväntat fel: {unexpected}");
                Console.ReadLine();
            }
            
        }

        // This runs when a user has logged in with ChooseExistingUser().
        public void UserLoggedInMenu(User newUser)
        {
            Console.Clear();
            Console.WriteLine("Välkommen till huvudmenyn.");
            Console.ReadLine();
        }
    }
}