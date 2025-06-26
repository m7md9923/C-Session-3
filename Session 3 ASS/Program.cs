namespace Session_3_ASS;

class Program
{
    static void Main(string[] args)
    {
        #region Question 1
        /*
            Write a program that allows the user to enter a number then print it.
        */
        Console.WriteLine("Plz Enter a number: ");
        int num;
        bool isNum = int.TryParse(Console.ReadLine(), out num);
        if(isNum) 
            Console.WriteLine($"The Num is : {num}");
        else 
            Console.WriteLine("Invalid Input");
        #endregion
    }
}