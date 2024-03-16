
using ClassLibraryProject;

namespace TestProject;

[Collection("Sequential")]
public class FileStorageTests
{
  // PART 2

  [Fact]
  public void SaveDateOnlyToFile_CanStoreDate()
  {
    DateOnly input = new DateOnly(1985, 1, 1);

    DateStorage.SaveDateOnlyToFile(input);
    string actual = File.ReadAllText(DateStorage.GetFilePath());
    string expected = "1985, 1, 1";

    Assert.Equal(expected, actual);
  }


  [Fact]
  public void SaveDateOnlyToFile_CanStoreDate_2()
  {
    DateOnly input = new DateOnly(1985, 1, 2);

    DateStorage.SaveDateOnlyToFile(input);
    string actual = File.ReadAllText(DateStorage.GetFilePath());
    string expected = "1985, 1, 2";

    Assert.Equal(expected, actual);
  }

  [Fact]
  public void SaveDateOnlyToFile_CanStoreDate_3()
  {
    DateOnly input = new DateOnly(1985, 1, 3);

    DateStorage.SaveDateOnlyToFile(input);
    string actual = File.ReadAllText(DateStorage.GetFilePath());
    string expected = "1985, 1, 3";

    Assert.Equal(expected, actual);
  }
  [Fact]
  public void SaveDateOnlyToFile_CanStoreDate_4()
  {
    DateOnly input = new DateOnly(1985, 1, 4);

    DateStorage.SaveDateOnlyToFile(input);
    string actual = File.ReadAllText(DateStorage.GetFilePath());
    string expected = "1985, 1, 4";

    Assert.Equal(expected, actual);
  }
}