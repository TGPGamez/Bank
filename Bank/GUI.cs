using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class GUI
    {
        private string[] menuItems = new string[] { "Insert money", "Withdraw money", "Card Information" };
        private int selectedItem = 0;

        public bool Status { get; private set; }
        public GUI(bool status)
        {
            Status = status;
        }

        public void MainMenu()
        {
            while(Status == true)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 0);
                SetChar('#', 40, ConsoleColor.White, ConsoleColor.White);
                for (int i = 0; i < menuItems.Length; i++)
                {
                    Console.WriteLine();
                    if (i == selectedItem)
                        WriteWithColor(" - " + menuItems[i], ConsoleColor.Red, ConsoleColor.Black);
                    else
                        WriteWithColor(" - " + menuItems[i], ConsoleColor.White, ConsoleColor.Black);
                }
                Console.WriteLine();
                SetChar('#', 40, ConsoleColor.White, ConsoleColor.White);
                Console.SetCursorPosition(0, 0);
                ConsoleKeyInfo consoleKey = Console.ReadKey();
                CheckInput(consoleKey);

            }
        }

        private void SetChar(char cha, int amount, ConsoleColor foreground, ConsoleColor background)
        {
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            for (int i = 0; i < amount; i++)
            {
                Console.Write(cha);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n");
        }

        private void WriteWithColor(string text, ConsoleColor foreground, ConsoleColor background)
        {
            Console.WriteLine(text, Console.ForegroundColor = foreground, Console.BackgroundColor = background);
        }

        private void CheckInput(ConsoleKeyInfo consoleKey)
        {
            switch (consoleKey.Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    if (selectedItem > 0)
                        selectedItem--;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    if (selectedItem < menuItems.Length - 1)
                        selectedItem++;
                    break;
                case ConsoleKey.Enter:
                    switch (selectedItem)
                    {
                        case 0:
                            InsertMenu();
                            break;
                        case 1:
                            WithdrawMenu();
                            break;
                        case 2:
                            CardInformation();
                            break;
                        default:
                            break;
                    }
                    break;
                case ConsoleKey.Escape:
                    Status = false;
                    break;
            }
        }

        private void InsertMenu()
        {
            Console.Clear();
            SetChar('#', 40, ConsoleColor.White, ConsoleColor.White);
            SetChar('#', 1, ConsoleColor.Black, ConsoleColor.Black);
            WriteWithColor("   Insert menu   ", ConsoleColor.White, ConsoleColor.Black);
            Console.WriteLine();
            WriteWithColor("Here you can insert money to you bank.", ConsoleColor.White, ConsoleColor.Black);
            WriteWithColor("How much do you want to insert? ", ConsoleColor.White, ConsoleColor.Black);
            SetChar('#', 40, ConsoleColor.White, ConsoleColor.White);
            Console.SetCursorPosition(32, 4);
            Console.WriteLine("Hej");
            Console.ReadKey();
        }
        private void WithdrawMenu()
        {

        }
        private void CardInformation()
        {

        }
    }
}
