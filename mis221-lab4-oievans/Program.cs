// Start Main
  Menu();



// End Main
 static void Menu()
 {
    System.Console.WriteLine("Enter 1 to display Cheddar Cheese, Enter 2 to Display Swiss Cheese enter 3 to exit.");
    string choice = Console.ReadLine();
    while(choice != "1" && choice != "2" && choice != "3")
    {
      System.Console.WriteLine("There was an error");
        System.Console.WriteLine("Enter 1 to display Cheddar Cheese, Enter 2 to Display Swiss Cheese enter 3 to exit.");
        choice = Console.ReadLine();
    }
    if(choice == "1") Cheddar();
    else if(choice == "2") Swiss();
    else if(choice == "3") System.Console.WriteLine("Goodbye");
 }

 static void Cheddar()
 {
    Random rnd = new Random();
    int rows = rnd.Next(3, 9);
    string output = "o";
    
    for(int i = 0; i <= rows; i++)
    {
        for(int j = 0; j < i; j++)
        {
            System.Console.Write(output + " ");
        }
        System.Console.WriteLine(Environment.NewLine);
    }

    Next();
 }

 static void Swiss()
 {
    Random rnd = new Random();
    int rows = rnd.Next(3, 9);
    string output = "o";
    
    for(int i = 0; i <= rows; i++)
    {
        int missing = rnd.Next(i);
        for(int j = 0; j < i; j++)
        {
            if(j == missing) System.Console.Write("  ");
            else System.Console.Write(output + " ");
        }
        System.Console.WriteLine(Environment.NewLine);
    }

    Next();
 }

static void Next()
{
  System.Console.WriteLine("would you like to make another cheese? Enter yes or no ");
  string next = Console.ReadLine();

  while(next.ToLower() != "yes" && next.ToLower() != "no")
  {
    System.Console.WriteLine("would you like to make another cheese? Enter yes or no ");
    next = Console.ReadLine();
  }

  if(next.ToLower() == "yes")
  {
    Menu();
  }
  else
  {
    System.Console.WriteLine("goodbye");
  }
}