using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSpace
{
    class Program
    {
        public static void RemoveSpace(char[] str)
        {
            //keep track of non space character by using the variable count
            int count = 0;
           // int newLength;

            //Iterate through all characters of the string, if its a non space then move the character to str[count+1] index 
            for (int i =0; i<str.Length;i++)
            {
                if( str[i] != ' ')
                {
                    
                    str[count++] = str[i];
                    
                }
               
            }
            while(count <= str.Length-1)
            {
                str[count] = '\0';
                count++;
            }
           
          
             



            //return str;
        }
        static void Main(string[] args)
        {
            string str = "I Love Icecream";
            char[] charArray = str.ToCharArray();
            RemoveSpace(charArray);
            Console.WriteLine(charArray);
          
        }
    }
}


//char[] delim = { ' ' };
//string[] strArr = str.Split(delim);
//foreach (var space in strArr)
//{
//    Console.Write(space);
//}
