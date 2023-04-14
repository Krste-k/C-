using System;
using System.Security;

public class cardHolder
{
    string cardNum;

    int pin;

    string firstName;

    public string lastName;

    double balance;
    public cardHolder(string cardNum, int pin, string firstname, string lastname, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstname;
        this.lastName = lastname;
        this.balance = balance;
    }
    public string GetNum()
    {
        return cardNum;
    }
    public int GetPin() 
    {
    return pin;
    }
    public string GetFirstName()
    {
        return firstName;
    }
    public string GetLastName()
    {
        return lastName;
    }
    public double GetBalance()
    {
        return balance;
    }

    public void SetNum(String newCardNum) 
    {
    cardNum = newCardNum;
    }
    public void SetPin(int newPin)
    {
        pin = newPin;
    }
    public void SetFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }
    public void SetLastName(String newLastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void PrintOptions()
        {
            Console.WriteLine("Please chose from one of the following options ...");
            Console.WriteLine("1) Deposit");
            Console.WriteLine("2) Withdraw");
            Console.WriteLine("3) Show Balance");
            Console.WriteLine("4) Exit");
        }
        void Deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $ would you like to deposit");
            double deposit = double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.GetBalance() + deposit);
            Console.WriteLine($"Thank you for yuor $ . Yuor new balance is :{currentUser.GetBalance()}");
        }
        void WithDrow(cardHolder currentUser)
        {
            Console.WriteLine("How much $ wold you like to withdraw: ");
           double withdrawal = double.Parse(Console.ReadLine());    
            if(currentUser.GetBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient balance ");
            }
            else
            {
               currentUser.setBalance(currentUser.GetBalance() - withdrawal);
                Console.WriteLine("you're good to go! thank you ");
            }        
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine($"Current balance :{currentUser.GetBalance()}");
        }
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("1234",1234,"Marko","Krstevski",121000000.59 ));
        cardHolders.Add(new cardHolder("1111", 9687, "Jon", "Miler", 15090.66));
        cardHolders.Add(new cardHolder("3434", 87786, "Stiv", "franc", 15212.59));
        cardHolders.Add(new cardHolder("4321", 654877, "David", "Benso", 12256.59));
        cardHolders.Add(new cardHolder("5846", 1234, "Marko", "Bodat", 1500.21));
        cardHolders.Add(new cardHolder("25015", 87688, "Shon", "davido", 1735.9));
        cardHolders.Add(new cardHolder("4563", 4566, "Patrik", "Semano", 1578.59));
        cardHolders.Add(new cardHolder("7898", 456, "Zumy", "Loren", 154574.50));
        cardHolders.Add(new cardHolder("546351", 654645, "Fernando", "Soman", 18780.59));
        cardHolders.Add(new cardHolder("46345", 45654, "laura", "smit", 1235));
        cardHolders.Add(new cardHolder("45654", 456564, "Lena", "guard", 180.11));
        cardHolders.Add(new cardHolder("45645", 45645, "Krste", "Krstevski", 505489455.9));

        Console.WriteLine("Welcome to sempleATM");
        Console.WriteLine("Please Insert yuor debit card :");

        string debitCardNum = "";
        cardHolder currentUser;
        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a  => a.cardNum == debitCardNum);
                if (currentUser != null) break;
                else { Console.WriteLine("Card not recognized. Please try again"); }
            }
            catch
            {
                Console.WriteLine("Card not recognized. Please try again"); 

            }
        }
        Console.WriteLine("Please enter yuor pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin =int.Parse(Console.ReadLine());
                if (currentUser.GetPin() == userPin) break;
                else { Console.WriteLine("Incorect pin please try again"); }
            }
            catch
            {
                Console.WriteLine("Incorect pin please try again");
            }
        }
        Console.WriteLine($"Welcome {currentUser.GetFirstName()} ");
        int option = 0;
        do
        {
            PrintOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch
            {

            }
            if (option == 1)
            {
                Deposit(currentUser);
            }
            else if (option == 2)
            {
                WithDrow(currentUser);
            }
            else if(option == 3)
            {
                balance(currentUser);
            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                option = 0;
            }

        }
        while (option != 4);
        Console.WriteLine("Thank you have a nice day ");


    }

}
