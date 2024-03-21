using ClassLibraryProject;

while (true)
{
  // user answer to menu with enforced validation
  // declare variable outside for loop so it is available outside loop
  int userAnswer = 0;
  bool answerIsValid = false;

  // loop until the user inputs a valid number
  while (!answerIsValid)
  {
    Console.WriteLine(@"
What would you like to do?
  1. Load a date from a file
  2. Store a date in a file
  3. Exit");
    string userAnswerAsString = Console.ReadLine();
    answerIsValid = true; // innocent until proven guilty

    bool answerIsNumber = int.TryParse(userAnswerAsString, out userAnswer);

    // check the three cases did not input an integer
    // invalid integers handled by switch statement
    if (!answerIsNumber)
    {
      answerIsValid = false;
      Console.WriteLine($"Invalid option input: {userAnswerAsString} \nPlease try again");
    }
  }

  // empty space for nice formatting
  Console.WriteLine();

  switch (userAnswer)
  {
    case 1:
      Console.WriteLine("Here is the date from the file");
      // TODO 1: check if the file exists, if the file does not exist, inform the user and break to run the loop again
      //         If the file exists, but it contains an invalid date, inform the user the data is corrupt and break to run the loop again
      DateOnly storedDate = DateStorage.LoadDateOnlyFromFile();
      Console.WriteLine(storedDate);
      break;

    case 2:
      Console.WriteLine("What date would you like to store? Input using the format 'year, month, day'");
      string userInputDate = Console.ReadLine();

      // TODO 2: Verify the date is valid before parsing using DateStorage.IsValidDateOnlyString
      //         If date is invalid, have the user try again until they input a valid date

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