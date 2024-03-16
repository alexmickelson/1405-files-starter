

using ClassLibraryProject;

while (true)
{
  Console.WriteLine(@"
What would you like to do?
  1. Load a date from a file
  2. Store a date in a file
  3. Exit");
  string userAnswerAsString = Console.ReadLine();
  // need to check if input is valid integer, othersise repeat the while loop
  int userAnswer = int.Parse(userAnswerAsString);

  Console.WriteLine();

  switch (userAnswer)
  {
    case 1:
      Console.WriteLine("Here is the date from the file");
      DateOnly storedDate = DateStorage.LoadDateOnlyFromFile();
      Console.WriteLine(storedDate);
      break;

    case 2:
      Console.WriteLine("What date would you like to store? Input using the format 'year, month, day'");
      string userInputDate = Console.ReadLine();

      // need to check if date is valid before parsing

      DateOnly date = DateStorage.ParseDateOnly(userInputDate);
      DateStorage.SaveDateOnlyToFile(date);
      break;


    default:
      Console.WriteLine("That is not a valid menu option, try again");
      break;
  }
  
}