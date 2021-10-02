using System;

enum Menu
{
    login = 1,
    Register,
    
}

namespace SystemKmuttbook
{
    class Program
    {
        static PersonList personList;

        static void Main(string[] args)
        {
            PreparePersonListWhenProgramIsLoad();
            PrintMenuScreen();
        }

        static void PreparePersonListWhenProgramIsLoad()
        {
            Program.personList = new PersonList();
        }

        static void PrintMenuScreen()
        {
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            InputMenuFromKeyboard();
        }

        static void PrintHeader()
        {
            Console.WriteLine("Welcome to Digital Library");
            Console.WriteLine("---------------------------");
        }

        static void PrintListMenu()
        {
            Console.WriteLine("1. login.");
            Console.WriteLine("2. Register.");
          
        }

        static void InputMenuFromKeyboard()
        {
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }

        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.login)
            {
                showloginUI();
            }
            else if (menu == Menu.Register)
            {
                showRegisterUI();
            }

            static void showloginUI()
            {
                Console.Clear();
                printheadloginUI();

            }
            static void showRegisterUI()
            {
                Console.Clear();
                Console.WriteLine("register new person");
                Console.WriteLine("---------------------");
                inputname();
                inputpassword();
                
                inputtype();
               
               
            }

            static void printheadloginUI()
            {
                Console.WriteLine("login screen");
                Console.WriteLine("--------------");
            }

            static void InputExitFromKeyboard()
            {
                string text = "";
                while (text != "exit")
                {
                    Console.WriteLine("Input: ");
                    text = Console.ReadLine();
                }

                Console.Clear();
                PrintMenuScreen();
            }
            static string inputname()
            {
                Console.Write("name ");
                return Console.ReadLine();
            }

            static string inputpassword()
            {
                Console.Write("password ");
                return Console.ReadLine();
            }

            static string inputtype()
            {
                
                Console.Write("Type ");

                return Console.ReadLine();
                

            }
            

        }

    }
}

