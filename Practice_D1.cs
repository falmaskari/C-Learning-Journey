namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args) //Initialization function which is called when program is run
        {
            //WriteLine() is a built-in function used to print a line
            Console.WriteLine("My name is Fatma Alzahra Abdullah Almaskari, " +
                "I complete my Bachlor's Degree in Computer Engineering" +
                "from National University of Science and Technology");

            //Variable is a storage location in the memory used to store value
            int x = 2; //Assign value 2 to x location in the memory
            int y = 3; //Assign value 3 in to y location in the memory

            //Check hash code for the both variables
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(y.GetHashCode());

            object obj = new object(); //Create objcet
            object obj1 = new object();

            //Check hash code for the both objects
            Console.WriteLine(obj.GetHashCode());
            Console.WriteLine(obj1.GetHashCode());

            /*String Concatenation
            Is used to combine variables to get one value
            */
            string name = "Fatma Alzahra";
            int age = 23;
            string job = "seeker";

            Console.WriteLine($"My name is {name}. I'm {age}. Currently, I'm {job}");

            var m = 10; //Var is used to detect the variable datatype during compile time
            //z = "Fatma";
            Console.WriteLine(m);

            dynamic n = 6; //Dynamic is used to detect the variable datatype during run time
            n = "Fatma";
            Console.WriteLine(n);

            /*Comparison Operators
            comparison Operators are used to compare two variables and return a boolren value of true or fase which is depends on the comparison resul
            */
            int a = 6;
            int b = 10;


            bool equal = a == b; //False
            bool notequal = a != b; //T
            bool lessthan = a < b; //T
            bool greaterthan = a > b; //F
            bool lesthanorequalto = a <= b; //T
            bool greaterhanorequalto = a >= b; //F

            /*xor operator
            xor operator compare between two variables and return a boolean value, if both are true it will return false. Otherwise it will return true
            */
            bool c = true, d = false;
            Console.WriteLine(c ^ d); //True
        }
    }
}
