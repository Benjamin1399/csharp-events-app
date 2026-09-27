using System;

namespace EventsApp
{
    public static class ConsoleHelper
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }
}
