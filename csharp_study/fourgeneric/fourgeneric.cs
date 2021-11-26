using System;

namespace fourgeneric
{

    class Sum
    {
        int num_1;
        int num_2;
        int sum;

        public int Sumab
        { get
            {
                return sum;
            }
            set
            {
                sum = value;
            }
            
        }
        public Sum(int _num1, int _num2)
        {
            num_1 = _num1;
            num_2 = _num2;

            Sumab = num_1 + num_2;

        }
        public Sum(float _num1, int _num2)
        {
            num_1 = (int)_num1;
            num_2 = _num2;

            Sumab = num_1 + num_2;

        }

        public Sum(int _num1, float _num2)
        {
            num_1 = _num1;
            num_2 = (int)_num2;

            Sumab = num_1 + num_2;

        }
        public Sum(double _num1, int _num2)
        {
            num_1 = (int)_num1;
            num_2 = _num2;

            Sumab = num_1 + num_2;

        }
        public Sum(int _num1, double _num2)
        {
            num_1 = _num1;
            num_2 = (int)_num2;

            Sumab = num_1 + num_2;

        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 ,로 나눠서 입력하세요");
            string[] input = Console.ReadLine().Split(",");
            int num_1 = int.Parse(input[0]);
            int num_2 = int.Parse(input[1]);
            float num_1 = float.Parse(input[0]);
            float num_ = float.Parse(input[0]);

            Sum plus = new(num_1, num_2);

            Console.WriteLine(plus.Sumab);
            Console.WriteLine(plus);
        }
    }
}
