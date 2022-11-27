using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal static  class Exstension
    {
        public static bool CustomContains(this string sentence, string search)
        {


            string toLower = sentence.ToLower();

            string whiteSpace = " ";

            bool startWith = toLower.StartsWith(search);

            bool endWith = toLower.EndsWith(search);

            String.IsNullOrWhiteSpace(whiteSpace);

            string[] arrayString = toLower.Split();




            foreach (var item in arrayString)
            {
                if (item == search)
                {
                    return true;
                }

                else if (toLower == search)
                {
                    return true;
                }

                else if (endWith)
                {
                    return true;
                }
                else if (item.ToUpper() == search.ToUpper())
                {
                    return true;
                }
                else if (item.StartsWith(search))
                {
                    return true;
                }
                else if (item.EndsWith(search))
                {
                    return true;
                }


            }

            char[] arrayChar = sentence.ToCharArray();


            foreach (var chars in arrayChar)

            {


                if (chars.ToString() == search)
                {
                    return true;

                }

                else if (startWith)
                {
                    return true;
                }

                else if (endWith)
                {
                    return true;
                }

            }

            return false;

        }
    }
}
