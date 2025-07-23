using System;

namespace Abstraction
{
    public class ConsoleInputService : InputService
    {
        public override string Read(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine() ?? string.Empty;
        }
    }
}