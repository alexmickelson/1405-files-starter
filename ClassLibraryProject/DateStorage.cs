using System.Net.NetworkInformation;

namespace ClassLibraryProject;

public static class DateStorage
{
  public static bool IsValidDateOnlyString(string input)
  {
    string[] parts = input.Split(",");
    string rawYear = parts[0].Trim();
    foreach (char letter in rawYear)
    {
      if (!char.IsDigit(letter))
        return false;
    }
    string rawMonth = parts[1].Trim();
    foreach (char letter in rawMonth)
    {
      if (!char.IsDigit(letter))
        return false;
    }

    string rawDay = parts[2].Trim();
    foreach (char letter in rawDay)
    {
      if (!char.IsDigit(letter))
        return false;
    }

    if (parts.Length > 3)
      return false;

    return true;
  }

  public static DateOnly ParseDateOnly(string input)
  {
    string[] parts = input.Split(",");
    int year = int.Parse(parts[0].Trim());
    int month = int.Parse(parts[1].Trim());
    int day = int.Parse(parts[2].Trim());
    return new DateOnly(year, month, day);
  }

  public static string CreateDateOnlyStorageString(DateOnly input)
  {
    return $"{input.Year}, {input.Month}, {input.Day}";
  }

  public static void SaveDateOnlyToFile(DateOnly input)
  {
    string storageDate = CreateDateOnlyStorageString(input);
    File.WriteAllText(GetFilePath(), storageDate);

  }

  public static DateOnly LoadDateOnlyFromFile()
  {
    string path = GetFilePath();
    if (StorageFileExists(path))
      return new DateOnly();

    string rawDateOnly = File.ReadAllText(path);
    return ParseDateOnly(rawDateOnly);
  }

  private static bool StorageFileExists(string path)
  {
    return !File.Exists(path);
  }

  public static string GetFilePath()
  {
    if (Directory.GetCurrentDirectory().Contains("ConsoleProject"))
      return "../MyDateStorage.txt";
    if (Directory.GetCurrentDirectory().Contains("TestProject"))
      return "../../../../MyDateStorage.txt";

    return "MyDateStorage.txt";
  }
}
