using System;
enum Menu
{
    Playgame = 1,
    Exit
}
namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenuScreen();
        }
        static void PrintMenuScreen()
        {
            PrintHeader();
            PrintList();
            InputMenuFromKeyboard();
        }
        static void PrintHeader()
        {
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("----------------------------------------");
        }
        static void PrintList()
        {
            Console.WriteLine("1. Play game.");
            Console.WriteLine("2. Exit.");
        }
        static void InputMenuFromKeyboard()
        {
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }
        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.Playgame)
            {
                ShowPlaygamescreen();
            }
            else if (menu == Menu.Exit)
            {
                Exit();
            }
            static void ShowPlaygamescreen()
            {
                Console.Clear();
                headgameplay();

            }
            static void headgameplay()
            {
                allword();
                Console.WriteLine("play hangman game");
                Console.WriteLine("--------------------");
                Console.WriteLine("Incorrect Score: [{0}]");

                
                

                Console.Write("input letter alphabet: ");
                string word = Console.ReadLine();
                
            }
            static void Exit()
            {
                Console.WriteLine("thank for play");
            }
            static int allword()
            {
                Random random = new Random();
                string[] wordBank = { "tennis", "football", "badminton", };
                int wordToGuess = random.Next(0, wordBank.Length);
                return wordToGuess;

               

            }
        }
    }
        
         
    }

