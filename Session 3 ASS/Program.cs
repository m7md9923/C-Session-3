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
        
        #region Question 4
        /*
         Write C# program that Extract a substring from a given string. (Search)
         */
        // Console.WriteLine("Plz Enter a string: ");
        // string str = Console.ReadLine();
        // Console.WriteLine("Plz Enter a substring to extract : ");
        // string substr = Console.ReadLine();
        //
        // int l = 0, r = 0;
        // bool found = false;
        // while (r < str.Length)
        // {
        //     if (str[r++] == substr[l++])
        //     {
        //         if (l == substr.Length)
        //         {
        //             found = true;
        //             break;
        //         }
        //     }
        //     else
        //     {
        //         r -= l - 1;
        //         l = 0;
        //     }
        // }
        // if(found)
        //     Console.WriteLine("Substring is found");
        // else
        //     Console.WriteLine("Not Found");
        //
        #endregion
        
        #region Question 5
        // /*
        //     Write C# program that Assigning one value type variable to another 
        //     and modifying the value of one variable and mention what will happen
        //  */
        // int a = 10;
        // int b = a;  // copy from a value
        //
        // Console.WriteLine("Before modification:");
        // Console.WriteLine($"a = {a}"); // 10
        // Console.WriteLine($"b = {b}");  // 10
        // b = 20; 
        // Console.WriteLine("After modifying b:");
        // Console.WriteLine($"a = {a}");  // 10
        // Console.WriteLine($"b = {b}");  // 20
        
        #endregion
        
        #region Question 6
        // /*
        //  Write C# program that Assigning one reference type variable to another
        //  and modifying the object through one variable and mention what will happen
        //  */
        //
        // object obj1 = 10 , obj2 = 20;
        // obj2 = obj1;  // both reference the same boxed value
        //
        // Console.WriteLine("Before modification:");
        // Console.WriteLine($"abj1 = {obj1}"); // 10
        // Console.WriteLine($"obj2 = {obj2}");  // 10
        //
        // obj2 = 20; //  new boxed object containing 20 is created and obj2 points to it.
        //
        // Console.WriteLine("After modifying b:");
        // Console.WriteLine($"abj1 = {obj1}"); // 10
        // Console.WriteLine($"obj2 = {obj2}");  // 20

        #endregion
    }
}