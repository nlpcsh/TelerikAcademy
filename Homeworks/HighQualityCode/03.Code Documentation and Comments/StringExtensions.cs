namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Static class that extend a string type
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Gets MD5 hash of a string
        /// </summary>
        /// <param name="input"> String to collect MD5 hash </param>
        /// <returns> Returns a hexadecimal string </returns>
        public static string ToMd5Hash(this string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] byteArray = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringCollector = new StringBuilder();

            for (int i = 0; i < byteArray.Length; i++)
            {
                stringCollector.Append(byteArray[i].ToString("x2"));
            }

            return stringCollector.ToString();
        }

        /// <summary>
        /// Checks if a string contains some of the values (ex: true, ok, yes, 1, да)
        /// </summary>
        /// <param name="input"> Used a string that should be checked if it has true value or not </param>
        /// <returns> Returns boolean value </returns>
        public static bool ToBoolean(this string input)
        {
            string[] stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts string representation of a number to its 16-bit signed integer equivalent
        /// </summary>
        /// <param name="input"> Used a string that contains short value to be checked </param>
        /// <returns> Returns the short value if conversion is possible and 0 if not possible </returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts a string representation of a number to its 32-bit signed integer equivalent
        /// </summary>
        /// <param name="input"> Used string, that represents 32-bit signed integer value to be checked </param>
        /// <returns> Returns 32-bit signed integer value if conversion is possible and 0 if not possible </returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts string representation of a number to its 64-bit signed integer equivalent
        /// </summary>
        /// <param name="input">string, that represents 64-bit signed integer value to be checked</param>
        /// <returns>Returns 64-bit signed integer value if conversion is possible and 0 if not possible </returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Converts string representation of a date and time to its System.DateTime equivalent
        /// </summary>
        /// <param name="input">string, that represents DateTime value to be checked</param>
        /// <returns>Returns DateTime value if conversion is possible or base date 01.01.0001 00:00:00 if not </returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Capitalizes first letter of a string
        /// </summary>
        /// <param name="input">string to capitalize first letter</param>
        /// <returns>
        /// Returns same string as the input parameter with first letter - capital.
        /// If the input parameter is null or empty string returns null or empty string.
        /// </returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Gets a string in between the two other strings
        /// </summary>
        /// <param name="input"> Initial string value to search from </param>
        /// <param name="startString">The string - left border of the searched string </param>
        /// <param name="endString">The string - right border of the searched string </param>
        /// <param name="startFrom">Index to point from where the searching should begin </param>
        /// <returns>
        /// Returns a string. If the start string or end string do not exist in the input, or some of them is "null" or empty - returns empty string.
        /// </returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            int startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            int endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Converts Cyrillic to Latin letters
        /// </summary>
        /// <param name="input"> String value that will be converted to Latin </param>
        /// <returns> Returns Latin letters string </returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            string[] bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            string[] latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (int i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Converts Latin to Cyrillic letters
        /// </summary>
        /// <param name="input"> String value that will be converted to Cyrillic </param>
        /// <returns> Returns string with Cyrillic letters </returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            string[] latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            string[] bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Converts the username string to a valid one (removes invalid chars for username)
        /// </summary>
        /// <param name="input"> String to test the username </param>
        /// <returns> Returns a valid username </returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts a string representation of a file name to its valid latin one (replaced Cyrillic letters with the latin and invalid chars)
        /// </summary>
        /// <param name="input"> String with the file name </param>
        /// <returns> Returns valid Latin file name </returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Gets the first defined sequence of characters from string
        /// </summary>
        /// <param name="input">string to manipulate</param>
        /// <param name="charsCount">32-signed integer value that shows the number of first characters</param>
        /// <returns>Returns first defined sequence of characters from string</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Gets file's extension from the string
        /// </summary>
        /// <param name="fileName"> String containing the file name </param>
        /// <returns> Returns the file extension as a sting. If the file name is invalid - returns an empty string </returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Gets the content type of the file's extension 
        /// </summary>
        /// <param name="fileExtension"> String for the file extension </param>
        /// <returns> Returns the file's content type. If the extension is not found returns a string = "application/octet-stream"
        /// </returns>
        public static string ToContentType(this string fileExtension)
        {
            Dictionary<string, string> fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Gets ASCII decimal value of each character in a string
        /// </summary>
        /// <param name="input"> String to convert to ASCII </param>
        /// <returns> Returns array with the ASCII code of each character in the string </returns>
        public static byte[] ToByteArray(this string input)
        {
            byte[] bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }

        /// <summary>
        /// Main method
        /// </summary>
        private static void Main()
        {
        }
    }
}