using System.Runtime.Intrinsics.Arm;

namespace Week2AssessmentQuestion1
{
    internal class Program
    {
            public string newDmv = "";
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1: ");
            Console.WriteLine("Enter the dmv number");
            string OriginalDmv = Console.ReadLine();
            Console.WriteLine("Enter the number to be separated : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            program.LicensePlate(OriginalDmv, number);
            Console.WriteLine("New DMV Number :  " + program.newDmv);

        }
    

        public void LicensePlate(string OriginalDmv, int number)
        {
            //separation via spliting based on '-'
            string[] RealDmvSep = OriginalDmv.Split("-");
            string dmv = "";
            foreach (string s in RealDmvSep)
            {
                //converting to upper case
                String upperString = s.ToUpper();
                dmv += upperString;
            }
            //assigning temporary value
            String temp = "";
            int count = 0;
            for (int i = dmv.Length - 1; i >= 0; i--)
            {
                if (count == number)
                {
                    temp += "-";
                    count = 0;
                }
                temp += dmv[i];
                count++;
            }
            string temp2 = "";
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                temp2 += temp[i];
            }
            newDmv = temp2;
        }

    }
}