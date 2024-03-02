using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity (1-5) or type 'exit' to end program:");
            string activity = Console.ReadLine();

            switch (activity)
            {
                case "1":
                    Activity1();
                    break;
                case "2":
                    Activity2();
                    break;
                case "3":
                    Activity3();
                    break;
                case "4":
                    Activity4();
                    break;
                case "5":
                    Activity5();
                    break;
                case "exit":
                    Console.WriteLine("Closing Program...");
                    return;
                default:
                    Console.WriteLine("Invalid activity: " + activity);
                    break;
            }
        }
    }

    static void Activity1()
    {
        Console.Write("Enter the denomination: ");
        string denomination = Console.ReadLine();

        switch (denomination)
        {
            case "0.01":
            case "0.05":
            case "0.25":
                Console.WriteLine("No Person is found");
                break;
            case "1":
                Console.WriteLine("{0} is found on {1} peso", "Jose Rizal", denomination);
                break;
            case "5":
                Console.WriteLine("{0} is found on {1} pesos", "Emilio Aguinaldo", denomination);
                break;
            case "10":
                Console.WriteLine("{0}, {1} is found on {2} pesos", "Andres Bonifacio", "Apolinario Mabini", denomination);
                break;
            case "20":
                Console.WriteLine("{0} is found on {1} pesos", "Manuel L. Quezon", denomination);
                break;
            case "50":
                Console.WriteLine("{0} is found on {1} pesos", "Sergio Osmena", denomination);
                break;
            case "100":
                Console.WriteLine("{0} is found on {1} pesos", "Manuel Roxas", denomination);
                break;
            case "200":
                Console.WriteLine("{0} is found on {1} pesos", "Diosdado Macapagal", denomination);
                break;
            case "500":
                Console.WriteLine("{0} and {1} are found on {2} pesos", "Benigno Sr.", "Corazon Aquino", denomination);
                break;
            case "1000":
                Console.WriteLine("{0}, {1}, {2} are found on {3} pesos", "Jose Abad Santos", "Vicente Lim", "Josefa Llanes Escoda", denomination);
                break;
            default:
                Console.WriteLine("Invalid Denomination: {0}", denomination);
                break;
        }
    }

    static void Activity2()
  {
      Console.Write("Enter a number: ");
      string input = Console.ReadLine();

      if (int.TryParse(input, out int X))
      {
          for (int i = 1; i <= X; i++)
          {
              if (i % 3 == 0 && i % 5 == 0)
              {
                  Console.WriteLine(i + " - FooBar");
              }
              else if (i % 3 == 0)
              {
                  Console.WriteLine(i + " - Foo");
              }
              else if (i % 5 == 0)
              {
                  Console.WriteLine(i + " - Bar");
              }
              else
              {
                  Console.WriteLine(i);
              }
          }
      }
      else
      {
          Console.WriteLine($"Invalid value: {input}");
      }
  }

    static void Activity3()
    {
        string userInput = "";
        string totalInput = "";
        Console.WriteLine("Enter text (type 'exit' to end program):");

        while ((userInput = Console.ReadLine()) != "exit")
        {
            totalInput += userInput + " ";
            Console.WriteLine("You entered: " + totalInput);
        }
        Console.WriteLine("Closing program...");
    }

    static void Activity4()
    {
        int number;
        while (true)
        {
            Console.Write("Enter a number or enter '0' to exit the program: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number) && number >= 0)
            {
                if (number == 0)
                {
                    Console.WriteLine("Closing Program...");
                    break;
                }

                for (int a = 0; a < number; a++)
                {
                    for (int b = 0; b < number - a - 1; b++)
                    {
                        Console.Write(" ");
                    }
                    for (int c = 0; c < 2 * a + 1; c++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Invalid value: {input}");
            }
        }
    }

    static void Activity5()
    {
        string userInput = "";
        string totalInput = "";
        int totalSum = 0;

        while (true)
        {
            Console.WriteLine();
            Console.Write("Enter something: ");
            userInput = Console.ReadLine();

            if (userInput == "exit")
            {
                break;
            }
            else if (int.TryParse(userInput, out int number))
            {
                totalSum += number;
                Console.WriteLine("Adding " + number + " to " + (totalSum - number) + " = " + totalSum);
            }
            else
            {
                totalInput += userInput;
                Console.WriteLine("Current Message is: " + totalInput);
            }
        }
        Console.WriteLine("Closing Program...");
    }
}
