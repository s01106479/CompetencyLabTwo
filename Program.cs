using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Add your name, course number, and CRN as a multi-line comment at the beginning of your code.
/* Isabella Tomasek
 * Course Number: 1050
 * CRN: 86411
 */
namespace CompetencyLabTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Create 5 integer variables u, v, w, x, and y. Assign values to each of them. Output the sum: u + v + w + x + y.
            int u = 2;
            int v = 4;
            int w = 6;
            int x = 8;
            int y = 10;

            Console.WriteLine(u + v + w + x + y);

            //3. Create a variable called name. Assign your name to it. Create a variable called major. Assign your major to the variable called major. Use string interpolation ($) to Output: [Your name]'s major is [major]. Example: student named John Smith whose major is Programming will output John's major is programming.
            string name = "Isabella";
            string major = "Computer Science";
            
            //string nameAndMajor = $"{name}'s major is {major}.";
            //Console.WriteLine(nameAndMajor);
            Console.WriteLine($"{name}'s major is {major}.");

            //4. Use the following given code Console.Write("Please enter the price: "); to prompt a user to enter a value in the console. Use the code string inputstr = Console.ReadLine( ); to read in a variable (whole numbers only) from the console. Then convert the variable inputstr to an integer value and assign it to an int variable called inputint. Then multiply inputint by 1.08 and output "The total price with tax is " + inputint (use the concatenation operator +).
            Console.Write("Please enter the price: "); //given

            string inputstr = Console.ReadLine();  //given

            int inputint = Convert.ToInt32(inputstr) * (int)1.08; //the int cast rounds it to the nearest whole number
            Console.WriteLine("The total price with tax is " + inputint); 

            //5. Use the increment operator to increment to add 1 to the number below and output the result.
            int number = 4358;
            number++;
            Console.WriteLine(number);

            //6. Create a string variable called season and assign your favorite season to it. Concatenate it to the following string using string interpolation($) and output the value.
            string favSeason = "My favorite season is ";    //given
            string season = "winter";
            Console.WriteLine($"{favSeason}{season}");

            //7. Output the following programming language variables separated by commas using the string concatenation operator(+). Your output will be C#, HTML, CSS, Python, Java
            string lang1 = "C#";     //given

            string lang2 = "HTML";  //given

            string lang3 = "CSS";  //given

            string lang4 = "Python";  //given

            string lang5 = "Java";     //given

            Console.WriteLine(lang1 + ", " + lang2 + ", " + lang3 + ", " + lang4 + ", " + lang5);

            //8. Divide the following variable by 100 and output the value.
            double num = 84.26;   //given
            Console.WriteLine(num / 100);

            //9. Add the two values together and output the sum.
            int operand1 = 357;     //given

            int operand2 = 119;     //given

            int sum = operand1 + operand2;
            Console.WriteLine(sum);

            //10. Evaluate the expression d * m + (s * 3) + 4 * m using the given values for d, m, and s. Output the value.
            double d = 1.8;            //given

            double m = 2.3; //given

            double s = 12.2; //given

            double value = d * m + (s * 3) + 4 * m;
            Console.WriteLine(value);

            //11. Convert the address to all uppercase and output the value using a single Console.WriteLine() statement and the newline escape sequence, so each variable is on a separate line
            string addr1 = "11000 W Pleasant Valley Road";  //given

            string addr2 = "Parma, Oh"; //given

            string addr3 = "44130"; //given

            Console.WriteLine(addr1.ToUpper() +"\n" + addr2.ToUpper() + "\n" + addr3.ToUpper());
        }
    }
}
