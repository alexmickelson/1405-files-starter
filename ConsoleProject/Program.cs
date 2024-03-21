

using ClassLibraryProject;

while (true)
{
  Console.WriteLine(@"
What would you like to do?
  1. Load a date from a file
  2. Store a date in a file
  3. Exit");
  string userAnswerAsString = Console.ReadLine();
  // TODO 1: alex write banna proofing
  int userAnswer = int.Parse(userAnswerAsString);

  Console.WriteLine();

  switch (userAnswer)
  {
    case 1:
      Console.WriteLine("Here is the date from the file");
      // TODO 2: check if the file exists, if the file does not exist, inform the user and loop again.
      //         If the file exists, but it does not have a valid date stored, inform the user the data is corrupt and loop again. 
      DateOnly storedDate = DateStorage.LoadDateOnlyFromFile();
      Console.WriteLine(storedDate);
      break;

    case 2:
      Console.WriteLine("What date would you like to store? Input using the format 'year, month, day'");
      string userInputDate = Console.ReadLine();

      // TODO 3: need to check if date is valid before parsing

      DateOnly date = DateStorage.ParseDateOnly(userInputDate);
      DateStorage.SaveDateOnlyToFile(date);
      break;

    case 3:
      Console.WriteLine("Exiting the program");
      return;

    default:
      Console.WriteLine("That is not a valid menu option, try again");
      break;
  }

}