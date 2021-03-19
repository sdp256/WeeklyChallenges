using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            
            return Convert.ToDouble(minuend - subtrahend);

        }

        public int Add(int number1, int number2)
        {
            return Convert.ToInt32(number1 + number2);
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 <= number2)
            {
                return Convert.ToInt32(number1);
            }
            else
            {
                return Convert.ToInt32(number2);
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return $"Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
