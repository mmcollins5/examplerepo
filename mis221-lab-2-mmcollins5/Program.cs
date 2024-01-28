const double MERCHANT_FLAT_FEE = 5.27;
const int COST_OF_SPELL = 10;

Console.WriteLine("Welcome to Penny Pincher's Quest");
string stringName;
System.Console.WriteLine("What is your name");
stringName = Console.ReadLine();
System.Console.WriteLine("Welcome to the tavern " + stringName);

int numberOfSpells;
System.Console.WriteLine("How many spells would you like to purchase?");
numberOfSpells = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Number of spells requested " + numberOfSpells);

int numberOfMagicalIngredients;
System.Console.WriteLine("How many magical ingredients would you like?");
numberOfMagicalIngredients = int.Parse(Console.ReadLine());

double offerings;
System.Console.WriteLine("How many offerings would you like to give?");
offerings = double.Parse(Console.ReadLine());


int totalSpellCost;
totalSpellCost = COST_OF_SPELL * numberOfSpells;
System.Console.WriteLine("Spell Cost: " + totalSpellCost);


double totalIngredientCost;
const double COST_OF_MAGIC_INGREDIENT = 0.25;
totalIngredientCost = COST_OF_MAGIC_INGREDIENT * numberOfMagicalIngredients;
System.Console.WriteLine("Ingredients Cost: " + totalIngredientCost);


double totalMerchantPayment;
totalMerchantPayment = MERCHANT_FLAT_FEE + offerings;
System.Console.WriteLine("Merchant Payment: " + totalMerchantPayment);


double goldOwed;
goldOwed = totalSpellCost + totalIngredientCost + totalMerchantPayment;
System.Console.WriteLine("Total Gold Owed: " + goldOwed + " pieces");

string goodbye;
System.Console.WriteLine("Your Potion is on the counter");
System.Console.WriteLine("Have a good day and safe travels " + stringName + "!" );
