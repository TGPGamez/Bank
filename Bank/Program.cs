using System;
using Bank.CardTypes;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            GUI gui = new GUI(true);
            gui.MainMenu();
        }
    }
}
