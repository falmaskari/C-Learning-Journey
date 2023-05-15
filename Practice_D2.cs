namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Array
			Array is a refernce type used to store set of elements with the same datatype in one variable in the contiguoes memory
			*/
            string[] str = new string[3]; //Array deceleration
            str[0] = "Fatma"; //Array initialization
            str[1] = "Saleh";
            str[2] = "Hajer";
            Console.WriteLine($"{str[0]} {str[1]} {str[2]}"); //Print array values

            /*Multi-Dimensional array
			Multi-Dimensional array is an array with rows and columns
			*/
            int[,] a = new int[2, 2]; //Multi-Dimensional array deceleration
            a[0, 0] = 1;  //Multi-Dimensional array initialization
            a[0, 1] = 2;
            a[1, 0] = 3;
            a[1, 1] = 4;
            Console.WriteLine($"{a[0, 0]} {a[0, 1]} {a[1, 0]} {a[1, 1]}");

            /*Jagged Array
			Jogged array is an array inside array "two arrays, sub array inside main array"
			*/
            int[][] b = new int[2][]
            {
                new int[] {1},
                new int[] {2}

            };
            Console.WriteLine($"{b[0][0]} {b[1][0]}");

            /*Array slicing
			Array slicing is divide an array into subs and takes a specific sequence from elements using range operator
			*/
            int[] numbers = new int[] { 1, 2, 3, 4, 5 }; //Array slicing deceleration and initialization
            int[] slice = numbers[1..4]; //Slice contains {2, 3, 4}
            Console.WriteLine(string.Join(" ", slice));
            int[] slice1 = numbers[..3]; //Slice contains {1, 2, 3}
            int[] slice2 = numbers[2..]; //Slice contains {3, 4, 5}
            int[] slice3 = numbers[2..^1]; //Slice contains {3, 4}
            Console.WriteLine(slice[0]);

            //Program to check wther the given number is even or odd
            int x = 10;
            /*Ternary operand
			Ternary operand is used to evaluate boolean expression and return one value
			*/
            string r = (x % 2 == 0) ? $"{x} is even" : "{x} is odd"; /*
			Here we will check if the module of the given number is 0 if true it wil print 10 is even
			if false it will print 10 is odd
			*/
            Console.WriteLine(r);

            int? z = null;
            string str_1 = null;
            str_1 = "F";
            string t = (str_1 == null) ? "S" : str_1;
            Console.WriteLine(str_1);

            string str_2 = null;
            string m = (str_1 == null) ? "S" : str_2;
            Console.WriteLine(str_2);

            string s1 = null;
            Console.WriteLine(s1?.ToUpper());


            {
                int y = 3;
                Console.WriteLine(y);
            }
            int c = 2;
            Console.WriteLine(c++);
            Console.WriteLine(++c);
        }
    }
}