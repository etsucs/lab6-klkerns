ShowCharacter();
CalculateRetail();
Celsius();
IsPrime();

static void ShowCharacter()
{
   String lnOfText;

int i;

Scanner input = new Scanner(Console.ReadLine());

Console.WriteLine("Enter a line of text:");

lnOfText = input.nextLine();

Console.WriteLine(" Enter your index: ");

i = input.nextInt();

show_Char(lnOfText,i);

Console.WriteLine(lnOfText);

}


static void CalculateRetail()
{
   Console.WriteLine("What was the wholesell cost?");
    string? charge = Console.ReadLine();
        int mealCharge = Convert.ToInt32(charge);

double tip = 0.20 * mealCharge;

const double TAX_RATE = 0.0675;
    double after = mealCharge * TAX_RATE;

double afterTaxes = after + mealCharge + tip;

Console.WriteLine("Wholesale Cost: $" + mealCharge);
}

static void IsPrime()
{
     var number;

Console.WriteLine("Accept number:");
number = Convert.ToInt32(Console.ReadLine());

if (IsPrime(number))
{
    Console.WriteLine("It is prime");
}
else
{
    Console.WriteLine("It is not prime");
}       

static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));
          
    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;
    
    return true;        
}   
}

static void Celsius()
{
    double fahrenheit;

         double celsius = 36;
         Console.WriteLine("Celsius: " + celsius);

         fahrenheit = (celsius * 9) / 5 + 32;
         Console.WriteLine("Fahrenheit: " + fahrenheit);
}




