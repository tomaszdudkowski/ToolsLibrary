using System;

namespace ToolsLibrary
{   
    /// <summary>
    /// Biblioteka Helpers
    /// Autor: Tomasz Dudkowski
    /// Data: 29.05.2020 20:05
    /// </summary>
    public static class Helpers
    {
        /// <summary>
        /// Kolorowanie składni terminala. Argument STRING
        /// </summary>
        /// <param name="consoleColor"><paramref name="consoleColor"/></param>
        /// <param name="Text"><paramref name="Text"/></param>
        public static void SyntaxColor(ConsoleColor consoleColor, string Text)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(Text);
            Console.ResetColor();
        }

        /// <summary>
        /// Kolorowanie składni terminala. Argument INT
        /// </summary>
        /// <param name="consoleColor"><paramref name="consoleColor"/></param>
        /// <param name="Arg"><paramref name="Arg"/></param>
        public static void SyntaxColor(ConsoleColor consoleColor, int Arg)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(Arg);
            Console.ResetColor();
        }

        /// <summary>
        /// Kolorowanie skłądni terminala. Argument FLOAT
        /// </summary>
        /// <param name="consoleColor"><paramref name="consoleColor"/></param>
        /// <param name="Arg"><paramref name="Arg"/></param>
        public static void SyntaxColor(ConsoleColor consoleColor, float Arg)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(Arg);
            Console.ResetColor();
        }

        /// <summary>
        /// Kolorowanie składni terminala. Argument DOUBLE
        /// </summary>
        /// <param name="consoleColor"><paramref name="consoleColor"/></param>
        /// <param name="Arg"><paramref name="Arg"/></param>
        public static void SyntaxColor(ConsoleColor consoleColor, double Arg)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(Arg);
            Console.ResetColor();
        }

        /// <summary>
        /// Konwertowanie STRING na Int32
        /// </summary>
        /// <param name="arg">arg</param>
        /// <returns>Int32.Parse(arg)</returns>
        public static dynamic Read(string arg)
        {
            return Int32.Parse(arg);
        }

        /// <summary>
        /// Konwertowanie STRING na FLOAT
        /// </summary>
        /// <param name="arg">arg</param>
        /// <returns>float.Parse(arg)</returns>
        public static float ReadFloat(string arg)
        {
            return float.Parse(arg);
        }

        /// <summary>
        /// Konwertowanie STRING na DOUBLE
        /// </summary>
        /// <param name="arg">arg</param>
        /// <returns>double.Parse(arg)</returns>
        public static double ReadDouble(string arg)
        {
            return double.Parse(arg);
        }

        /// <summary>
        /// Kopiowanie dynamiczne
        /// </summary>
        /// <param name="toCopy">dynamic toCopy</param>
        /// <returns>prettyCopy</returns>
        public static dynamic DynamicCopy(dynamic toCopy)
        {
            var prettyCopy = toCopy;
            return prettyCopy;
        }

        /// <summary>
        /// Konwertowanie Int do Int Array
        /// </summary>
        /// <param name="value"></param>
        /// <returns>intArray</returns>
        public static int[] IntToArray(int value)
        {
            char[] charArray = new char[11];
            charArray = value.ToString().ToCharArray();
            int[] intArray = new int[11];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = charArray[i] - 48;
            }

            return intArray;
        }

        /// <summary>
        /// Konwertowanie Long do Int Array
        /// </summary>
        /// <param name="value"></param>
        /// <returns>intArray</returns>
        public static int[] LongToIntArray(long value)
        {
            char[] charArray = new char[11];
            charArray = value.ToString().ToCharArray();
            int[] intArray = new int[11];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = charArray[i] - 48;
            }

            return intArray;
        }
    }
}
