using System.Runtime.Intrinsics.Arm;
namespace Week2AssessmentQuestion1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Performance perform = new Performance();
            Console.WriteLine("Question 1: ");
            Console.WriteLine("Enter the dmv number");
            string OriginalDmv = Console.ReadLine();
            Console.WriteLine("Enter the number to be separated : ");
            int num = Convert.ToInt32(Console.ReadLine());
            perform.LicensePlate(OriginalDmv, num);
            Console.WriteLine("New DMV Number :  " + perform.newDmvNumber);
        }
    }
    public class Performance
    {
        public string newDmvNumber = "";

        public void LicensePlate(string OriginalDmvNumber, int num)
        {
            //separation via spliting based on '-'
            string[] RealDmvSep = OriginalDmvNumber.Split("-");
            string dmv = "";
            foreach (string s in RealDmvSep)
            {
                //converting to upper case
                String upperString = s.ToUpper();
                dmv += upperString;
            }
            //assigning temporary value
            string temporary1 = "";
            string temporary2 = ""; // because it overwrites the exist one in temporary 1
            int count = 0;
            for (int eachLetter = dmv.Length - 1; eachLetter >= 0; eachLetter--)
            {
                if (count == num)
                {
                    temporary1 += "-";
                    count = 0;
                }
                //appending into temporary variable
                temporary1 += dmv[eachLetter];
                count++;
            }
            for (int exchangeEachLetter = temporary1.Length - 1; exchangeEachLetter >= 0; exchangeEachLetter--)
            {
                temporary2 += temporary1[exchangeEachLetter];
            }
            newDmvNumber = temporary2;
        }
    }

}
