namespace Session_3_ASS;

class Program
{
    static void Main(string[] args)
    {
        #region Question 1
        // /*
        //     Write a program that allows the user to enter a number then print it.
        // */
        // Console.WriteLine("Plz Enter a number: ");
        // int num;
        // bool isNum = int.TryParse(Console.ReadLine(), out num);
        // if(isNum) 
        //     Console.WriteLine($"The Num is : {num}");
        // else 
        //     Console.WriteLine("Invalid Input");
        #endregion

        #region Question 2

        // /*
        //   Write C# program that converts a string to an integer, but the string contains non-numeric characters.
        //   And mention what will happen 
        // */
        // Console.WriteLine("Plz Enter a string: ");
        // string str;
        // str = Console.ReadLine();
        // int num;
        // bool check = int.TryParse(str , out num);
        // if(check) 
        //     Console.WriteLine($"The Num is : {num}");
        // else
        //     Console.WriteLine("Invalid Input");
        //
        // /*
        //     if u enter non numeric data --> format exception when u do not handle it 
        //     when use TryParse() --> if string contain non numeric data func returns False  else returns True   
        // */
        //
        #endregion
        
        #region Question 3
        // /*
        //  * Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
        //  */
        //
        // double num1 = 10.7; 
        // double num2 = 5.4;
        // double add = num1 + num2;
        // double sub = num1 - num2;
        // double mul = num1 * num2;
        // double div = num1 / num2;
        // Console.WriteLine($"sum : {add}");
        // Console.WriteLine($"subtract : {sub}");
        // Console.WriteLine($"multiply : {mul}");
        // Console.WriteLine($"divide : {div}");
        //
        // // what happen ? 
        // // work normally and print floating point result 
        // not highly precision --> if u want this u must use decimal intead of double
        #endregion
        
    }
}