using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_firm_v2.View
{
    internal class View
    {
        /// <summary>
        /// Outputs a custom message based on the parameter
        /// </summary>
        /// <param name="message"></param>
        internal void Message(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Changes the color every time the method gets called, due to the value parameter.
        /// It only gets called from the Controller.Output method, in which 'i' from the for loop becomes the value parameter.
        /// </summary>
        /// <param name="value"></param>
        internal void ColorChange(int value)
        {
            if(value % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            } else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
