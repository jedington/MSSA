using System;

namespace MSSA.Cash.Register
{
    public class Program
    {
        static (double, double) VerifyInput()
        {
            double purchaseAmount = UserInput($"Please enter a valid Purchase Amount: $"); // Purchase
            double paymentAmount = UserInput($"Please enter a valid Payment Amount: $"); // Payment

            while (paymentAmount <= purchaseAmount)
            {
                if (paymentAmount < purchaseAmount)
                {
                    TypeAnimate($"\nProcessing Order...\nError, Payment is not enough.\n");
                    paymentAmount = UserInput($"\n...Please enter a valid Payment Amount: $");                   
                }
                if (paymentAmount == purchaseAmount)
                {
                    TypeAnimate($"\nProcessing Order...\nNo change is necessary!\n");
                    break;
                }
            }
            return (paymentAmount, purchaseAmount);
        }

        static double UserInput(string inputRcv)
        {
            double amountXmt = 0;
            bool checkInput = false;
            while (checkInput == false)
            {
                try
                {
                    if (amountXmt <= 0)
                    {
                        Console.Write(inputRcv);
                        amountXmt = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        checkInput = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a real value...");
                }
            }
            return amountXmt;
        } // UserInput method ends

        static void TypeAnimate(string typewriteRcv) // just for fun
        {
            for (int i = 0; i < typewriteRcv.Length; i++)
            {
                Console.Write(typewriteRcv[i]);
                System.Threading.Thread.Sleep(30);
            }
        } // TypewriteAnimate method ends

        static double CalcChange(double changeRcv, double changeNum, string changeType)
        {
            int changeCheck = (int)(changeRcv / changeNum);
            if (changeCheck > 0)
            {
                Console.WriteLine($"Will receive: {changeCheck} in {changeType} back.");
            }
            return Math.Round(changeRcv % changeNum, 2);
        } // CalcChange method ends

        static void GiveChange(double changeDue)
        {
            if (changeDue > 0)
            {
                TypeAnimate($"\nProcessing Order...\nTotal amount given back: ${changeDue}\n");
            }
            changeDue = CalcChange(changeDue, 20.00, "Twenties");
            changeDue = CalcChange(changeDue, 10.00, "Tens");
            changeDue = CalcChange(changeDue, 05.00, "Fives");
            changeDue = CalcChange(changeDue, 01.00, "Ones");
            changeDue = CalcChange(changeDue, 00.25, "Quarters");
            changeDue = CalcChange(changeDue, 00.10, "Dimes");
            changeDue = CalcChange(changeDue, 00.05, "Nickels");
            CalcChange(changeDue, 00.01, "Pennies");
        } // ReturnChange method ends

        public static void Main(string[] args)
        {
            (double paymentAmount, double purchaseAmount) = VerifyInput();
            double changeGive = Math.Round(paymentAmount - purchaseAmount, 2);
            GiveChange(changeGive);
            TypeAnimate($"\nThank you! Goodbye.\n");
        } // Main method ends
    } // class ends
} // namespace ends