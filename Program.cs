using System;
using System.Text;

namespace StringBuilderUses
{
    public class Program
    {
        /// <summary>
        /// Points to Remember :
        ///StringBuilder is mutable.
        ///StringBuilder performs faster than string when appending multiple string values.
        ///Use StringBuilder when you need to append more than three or four strings.
        ///Use the Append() method to add or append strings to the StringBuilder object.
       ///Use the ToString() method to retrieve a string from the StringBuilder object.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Welcome to String Builder Tutorial ");
            string Text = "Hello Don";
            string MutableText=CreateMutableString(Text);
            Console.WriteLine("Mutable string is " + MutableText);
            AppendString();
            AppendFormatMutableString();
            InsertInMutableString();
            RemoveFromImutablestring();
            ReplaceInMutableString();
        }

        private static string CreateMutableString(string Text)
        {
            StringBuilder sb= new StringBuilder(Text);
            //sb is not a string it is a stringbilderObject so we have to convert it into string
            return sb.ToString();
        }

        private static void AppendString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.AppendLine(" World");
            sb.Append("C# Developer ");
           // sb.AppendFormat("{ 0:c}",25);
            Console.WriteLine(sb.ToString());
        }

        private static void AppendFormatMutableString()
        {
            StringBuilder sb = new StringBuilder("Your Total amount is ");
            sb.AppendFormat("{0:C}", 25);
            Console.WriteLine(sb);

        }

        private static void InsertInMutableString()
        {
            StringBuilder sb = new StringBuilder("Hello World");
            sb.Insert(5, "C#");
            Console.WriteLine(sb);
        }

        private static void RemoveFromImutablestring()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("hello World");
            Console.WriteLine("String before Remove ");
            Console.WriteLine(sb);
            Console.WriteLine("String After Remove ");
            sb.Remove(3, 6);
            Console.WriteLine(sb);
        }

        private static void ReplaceInMutableString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hello World");
            Console.WriteLine("String Before Replace ");
            Console.WriteLine(sb);
            sb.Replace("World", "C#");
            Console.WriteLine("string After Replace ");
            Console.WriteLine(sb);
        }
    }
}