bool runProgram = true;

//Dictionary
Dictionary<string, decimal> shoppingList = new Dictionary<string, decimal>();
shoppingList.Add("apple", 0.99m);
shoppingList.Add("banana", 0.59m);
shoppingList.Add("cauliflower", 1.59m);
shoppingList.Add("dragonfruit", 2.19m);
shoppingList.Add("elderberry", 1.79m);
shoppingList.Add("figs", 2.09m);
shoppingList.Add("grapefruit", 1.99m);
shoppingList.Add("honeydew", 3.49m);

decimal total = 0.00m;
List<string> order = new List<string>();



//Questions
do
{
    foreach (KeyValuePair<string, decimal> kvp in shoppingList)
    {
        Console.WriteLine($"{kvp.Key}, {kvp.Value}");
    }
    Console.WriteLine("What item would you like to order?");
    string userInput = Console.ReadLine().Trim().ToLower();
    
    if (shoppingList.ContainsKey(userInput))
    {
        decimal itemPrice = shoppingList[userInput];
        Console.WriteLine($"Adding {userInput} to cart at {itemPrice}");
        order.Add(userInput);
        total = total + itemPrice;
    }
    else
    {
        Console.WriteLine("Sorry. We don't have those. Please try again");
    }
    
        Console.WriteLine("Would you like to order anything else? (y/n)");
        string userAnswer = Console.ReadLine().Trim().ToLower();
        if (userAnswer == "y")
        {
            runProgram = true;
            
        }
        else if (userAnswer == "n")
        {
            Console.WriteLine("Here is your order:");
        foreach (string o in order)
        {
            Console.WriteLine($"{o} {shoppingList[o]}");
         
        }
        decimal avg = total / order.Count();
        decimal avgRound = Math.Round(avg, 2);
        Console.WriteLine($"Your total price for your order is: {total}");
        Console.WriteLine($"Average price per item in order was {avgRound}");
        runProgram = false;
            
        }
        else
        {
        Console.WriteLine("Please try again");
        }
    
} while (runProgram != false);