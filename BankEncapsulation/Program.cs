namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            double deposit;
            var account = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");
            Console.WriteLine("Enter a valid numberical amount: ");
            bool isValid = double.TryParse(Console.ReadLine(), out deposit);
            
                        while(isValid == false)
                        {
                            Console.WriteLine("Enter a valid numberical amount: ");
                            isValid = double.TryParse(Console.ReadLine(), out deposit);
                        }

            account.Deposit(deposit);

            Console.WriteLine("Would you like to check your balance?");
                        Console.WriteLine("Type 1 for Yes and 2 for No");           //Easier on the user


                        bool validInput = int.TryParse(Console.ReadLine(), out int userInput);
                        while (userInput != 1 && userInput != 2 || validInput == false)
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Type 1 for Yes and 2 for No");
                            validInput = int.TryParse(Console.ReadLine(), out userInput);
                         }

                        if (userInput == 1)
                        {
                          Console.WriteLine($"Your account balance is ${account.GetBalance()}");
                            Console.WriteLine("Thank you and have a good day!");
                        } else if (userInput == 2)
                        {
                            Console.WriteLine("Thank you and have a good day!");
                        } else
                        {

                        }
        }
    }
}

/*

In your BankAccount class, create the following:
A private field of type double named **balance **with a value of 0
Define a method named Deposit that will accept a double and store that value in the balance field
Define a method named GetBalance that will return the amount stored in the balance field
In the main method of your application, create a new instance of the BankAccount class.
Allow the user of the application to Deposit money and retrieve their balance through the console.
*/