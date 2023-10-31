using System.Text;

namespace L01.MutableStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateWithString());
            Console.WriteLine("-----------------------");
            Console.WriteLine(GenerateWithStringBuilder());
        }
        static string GenerateWithString()
        {
            string? str = null;

            str += String.Concat(new char[] { 'E', 'T', 'I' }); // ETI

            str += String.Format("GAT{0}{1}{2}", 'O', 'P', 'S'); // GATOPS

            str = "M" + str; // METIGATOPS

            str = str.Replace('P', 'R'); //METIGATORS

            str = str.Remove(str.Length - 1); // METIGATOR 

            return str;
        }
        static string GenerateWithStringBuilder()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(new char[] { 'E', 'T', 'I' }); // ETI

            sb.AppendFormat("GAT{0}{1}{2}", 'O', 'P', 'S'); // ETIGATOPS

            sb.Insert(0, "M"); // METIGATOPS

            sb.Replace('P', 'R'); //METIGATORS

            sb.Remove(sb.Length - 1, 1); // METIGATOR 

            return sb.ToString();


        }
    }
}