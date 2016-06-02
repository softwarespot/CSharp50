using System;

namespace CSharp50
{
    /// <summary>
    ///     Based on the original CS50 Library 5, but ported across to C#
    ///     https://manual.cs50.net/library
    ///     All rights belong to the authors of the original CS50 library
    ///
    ///     Note: Class names are used instead of aliases e.g. Double or Int32 when a static method
    ///     or static property is used. This is for readability purposes only and is considered a good practice
    /// </summary>
    public static class CSharp50
    {
        /// <summary>
        ///     Reads a line of text from standard input and returns the equivalent
        ///     char; if text does not represent a char, user is prompted to retry.
        ///     Leading and trailing white-space is ignored. If line can't be read,
        ///     returns Char.MaxValue.
        /// </summary>
        /// <returns>User input char; otherwise, Char.MaxValue.</returns>
        public static char GetChar()
        {
            // Try to get a char from user
            while (true)
            {
                // Get line of text, returning Char.MaxValue on failure
                string line = GetString();
                if (line == null)
                {
                    return Char.MaxValue;
                }

                // Return a char if only a char (possibly with
                // leading and/or trailing white-space) was provided
                if (line.Length == 1)
                {
                    return line[0];
                }

                Console.Write("Retry: ");
            }
        }

        /// <summary>
        ///     Reads a line of text from standard input and returns the equivalent
        ///     double as precisely as possible; if text does not represent a
        ///     double, user is prompted to retry.  Leading and trailing white-space
        ///     is ignored.  For simplicity, overflow and underflow are not detected.
        ///     If line can't be read, returns Double.MaxValue.
        /// </summary>
        /// <returns>User input double; otherwise, Double.MaxValue.</returns>
        public static double GetDouble()
        {
            // Try to get a double from user
            while (true)
            {
                // Get line of text, returning Double.MaxValue on failure
                string line = GetString();
                if (line == null)
                {
                    return Double.MaxValue;
                }

                // Return a double if only a double (possibly with
                // leading and/or trailing white-space) was provided
                double output;
                if (Double.TryParse(line.Trim(), out output))
                {
                    return output;
                }

                Console.Write("Retry: ");
            }
        }

        /// <summary>
        ///     Reads a line of text from standard input and returns the equivalent
        ///     float as precisely as possible; if text does not represent a float,
        ///     user is prompted to retry. Leading and trailing white-space is ignored.
        ///     For simplicity, overflow and underflow are not detected. If line can't
        ///     be read, returns Single.MaxValue.
        /// </summary>
        /// <returns>User input float; otherwise, Single.MaxValue.</returns>
        public static float GetFloat()
        {
            // Try to get a float from user
            while (true)
            {
                // Get line of text, returning Single.MaxValue on failure
                string line = GetString();
                if (line == null)
                {
                    return Single.MaxValue;
                }

                // Return a float if only a float (possibly with
                // leading and/or trailing white-space) was provided
                float output;
                if (Single.TryParse(line.Trim(), out output))
                {
                    return output;
                }

                Console.Write("Retry: ");
            }
        }

        /// <summary>
        ///     Reads a line of text from standard input and returns it as an
        ///     int in the range of [-2^31 + 1, 2^31 - 2], if possible; if text
        ///     does not represent such an int, user is prompted to retry. Leading
        ///     and trailing white-space is ignored. For simplicity, overflow is not
        ///     detected. If line can't be read, returns Int32.MaxValue.
        /// </summary>
        /// <returns>User input int; otherwise, Int32.MaxValue.</returns>
        public static int GetInt()
        {
            // Try to get an int from user
            while (true)
            {
                // Get line of text, returning Int32.MaxValue on failure
                string line = GetString();
                if (line == null)
                {
                    return Int32.MaxValue;
                }

                // Return an int if only an int (possibly with
                // leading and/or trailing white-space) was provided
                int output;
                if (Int32.TryParse(line.Trim(), out output))
                {
                    return output;
                }

                Console.Write("Retry: ");
            }
        }

        /// <summary>
        ///     Reads a line of text from standard input and returns the equivalent
        ///     long in the range [-2^63 + 1, 2^63 - 2], if possible; if text
        ///     does not represent such a long, user is prompted to retry.
        ///     Leading and trailing white-space is ignored. For simplicity, overflow
        ///     is not detected. If line can't be read, returns Int64.MaxValue.
        ///     Note: This is formerly known as GetLongLong(), but there is no long long
        ///     datatype in C#, only long.
        /// </summary>
        /// <returns>User input long; otherwise, Int64.MaxValue.</returns>
        public static long GetLong()
        {
            // Try to get a long from user
            while (true)
            {
                // Get line of text, returning Int64.MaxValue on failure
                string line = GetString();
                if (line == null)
                {
                    return Int64.MaxValue;
                }

                // Return a double if only a double (possibly with
                // leading and/or trailing white-space) was provided
                long output;
                if (Int64.TryParse(line.Trim(), out output))
                {
                    return output;
                }

                Console.Write("Retry: ");
            }
        }

        // GetString
        /// <summary>
        ///     Reads a line of text from standard input and returns it as a
        ///     string (char*), sans trailing newline character. (Ergo, if
        ///     user inputs only "\n", returns "" not NULL.) Returns NULL
        ///     upon error or no input whatsoever (i.e., just EOF). Leading
        ///     and trailing white-space is not ignored.
        /// </summary>
        /// <returns>User input string; otherwise, null.</returns>
        public static string GetString()
        {
            while (true)
            {
                string line;
                try
                {
                    // Get line of text, returning null on failure
                    line = Console.ReadLine();
                    if (line == null)
                    {
                        return null;
                    }
                }
                catch
                {
                    return null;
                }

                // Check if line is an EOL character
                if (line == Environment.NewLine)
                {
                    return String.Empty;
                }

                return line.Trim();
            }
        }
    }
}
