using System.Net.NetworkInformation;

namespace ClassLibraryProject;

public static class DateStorage
{
  public static bool IsValidDateOnlyString(string input)
  {
    return true;
  }

  public static DateOnly ParseDateOnly(string input)
  {
    return new DateOnly();
  }

  public static string CreateDateOnlyStorageString(DateOnly input)
  {
    return "";
  }

  public static void SaveDateOnlyToFile(DateOnly input)
  {
  }

  public static DateOnly LoadDateOnlyFromFile()
  {
  }

  // do not change this function
  private static bool StorageFileExists(string path)
  {
    return !File.Exists(path);
  }

  // do not change this function
  public static string GetFilePath()
  {
    // this function correctly provides a relative path to the MyDateStorage.txt file
    // when running as a test, from the solution directory, or from the console directory
    if (Directory.GetCurrentDirectory().Contains("ConsoleProject"))
      return "../MyDateStorage.txt";
    if (Directory.GetCurrentDirectory().Contains("TestProject"))
      return "../../../../MyDateStorage.txt";

    return "MyDateStorage.txt";
  }
}
