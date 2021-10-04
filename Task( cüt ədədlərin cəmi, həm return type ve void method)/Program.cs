using System;

namespace Task__cüt_ədədlərin_cəmi__həm_return_type_ve_void_method_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Returneven(4));
            Evenvoid(4);
        }

        public static int Returneven(int num)
        {
            int sum = 0;
            for (int i = 1; i <=num; i++)
            {
                if (i%2==0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static void Evenvoid(int num)
        {
            int sum = 0;
            for (int i = 1; i <=num; i++)
            {
                if (i%2==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
            
			
        
        
        
        
        
    }
}
