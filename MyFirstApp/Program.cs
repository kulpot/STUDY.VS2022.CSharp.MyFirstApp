public class MyFirstApp
{
    //primitive data types - are already provided by C#
    // Explicitly defined 
    float price = 3.99f;
    string name = "Jannick";
    char letter = 'a';
    int number = 1000000;
    bool toggle = true;





                            // a variable available inside the class
    static float vat = 19f; //(scope of the class)varible outside static main method

    public static void Main() // <- Method
    {
        /// <summary>
        /// This is the entry point of our application
        /// </summary>

        // Your Task: create a program to swap two numbers // easies algorithm

        int a = 5;
        int b = 20;

        //logic
        int templ = a; // 5
        a = b;// a = 20
        b = templ;// b = 5

        // Result
        Console.WriteLine("a is: " + a + " and b is: " + b);




        // Implicitly defined -- only inside a method---compiler fits what variable for var
        var username1 = "jannick";
        var username2 = 1000;
        var username3 = true;

        int aa = 1; // <- 1. first definition
        int bb = 2;

        aa = 5;

        int cc = aa + bb;
        Console.WriteLine("Result is: " + cc);

        string username = "Default";

        //logic

        // user has to enter his username
        username = "whatever the user has typed";

        float vat = 15f; // variable available only inside this static method
        float productA = 3.99f;
        float productB = 11.99f;
        float productC = 5.75f;

        float summed = productA + productB + productC;
        // dont forget to add local vat
        //vat is required, dont skip it
        float totalTax = (summed / 100) * vat;

        summed += totalTax; //summed = summed + totalTax;

        Console.WriteLine("Total price is: " + summed);
        Console.WriteLine("Total vat is:" + vat);
    }
    /*
    public static void Calculate()
    {
        //float vat = 15; //<- variable available to public class
        Console.WriteLine("Vat is " + vat);
    }*/
}



   
