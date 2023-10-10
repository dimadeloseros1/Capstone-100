string[] lockerContents = new string[101];
int options = 5, menu = 1, lockerNum;
string stored;


do
{
    Console.Clear();
    // Make the Headline of the application
    Console.WriteLine("Airport Locker Rental Menu");
    Console.WriteLine("==========================");
    // Print the 5 options of the application
    Console.WriteLine("1. View a locker");
    Console.WriteLine("2. Rent a locker");
    Console.WriteLine("3. End a locker rental");
    Console.WriteLine("4. List all locker contents");
    Console.WriteLine("5. Quit");
    // Prompt the user to choose 1 of the 5 available options
    Console.Write("Enter your choice (1-5): ");
    if (int.TryParse(Console.ReadLine(), out menu))
    {
        if (menu < 1 || menu > options)
        {
            Console.WriteLine("Please make sure that the numbers are 1 to 5");
        }

        if (menu == 5)
        {
            break;
        }
    }

    switch (menu)
    {
        case 1:
            do
            {
                Console.Write("Enter locker number (1-100): ");
                if (int.TryParse(Console.ReadLine(), out lockerNum) && lockerNum >= 1 && lockerNum <= 100)
                {
                    if (string.IsNullOrEmpty(lockerContents[lockerNum]))
                    {
                        Console.WriteLine($"Locker {lockerNum} is EMPTY.");
                    }
                    else
                    {
                        Console.WriteLine($"Locker {lockerNum} contents: {lockerContents[lockerNum]}");
                    }
                }
                else
                {
                    Console.WriteLine("Please make sure that the number is between 1 and 100.");
                }
                break;
            } while (true);
            break;

        case 2:
            do
            {
                Console.Write("Enter locker number (1-100): ");
                if (int.TryParse(Console.ReadLine(), out lockerNum) && lockerNum >= 1 && lockerNum <= 100)
                {
                    if (string.IsNullOrEmpty(lockerContents[lockerNum]))
                    {
                        Console.Write("Enter the item you want to store in the locker: ");
                        stored = Console.ReadLine();

                        if (!string.IsNullOrEmpty(stored))
                        {
                            lockerContents[lockerNum] = stored;
                            Console.WriteLine($"Locker {lockerNum} has been rented {stored} storage.");
                        }
                        else
                        {
                            Console.WriteLine("Please make sure that there is an input.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, but locker {lockerNum} has already been rented!");
                    }
                }
                else
                {
                    Console.WriteLine("Make sure that the input is a number 1 to 100(inclusive).");
                }
                break;
            } while (true);
            break;

        case 3:
            do
            {
                Console.Write("Enter locker number (1-100): ");
                if (int.TryParse(Console.ReadLine(), out lockerNum) && lockerNum >= 1 && lockerNum <= 100)
                {
                    if (!string.IsNullOrEmpty(lockerContents[lockerNum]))
                    {
                        lockerContents[lockerNum] = null;
                        Console.WriteLine($"You have successfully emptied locker {lockerNum}");
                    }
                    else
                    {
                        Console.WriteLine($"Locker {lockerNum} is already EMPTY.");
                    }
                }
                else
                {
                    Console.WriteLine("Please make sure that the numbers are from 1 to 100(inclusive).");
                }
                break;
            } while (true);
            break;

        case 4:
            for (int i = 1; i < lockerContents.Length; i++)
            {
                if (!string.IsNullOrEmpty(lockerContents[i]))
                {
                    Console.WriteLine($"Locker {i}: {lockerContents[i]}");
                }
            }
            break;
    }
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadLine();

} while (true);