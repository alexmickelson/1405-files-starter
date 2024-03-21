using ClassLibraryProject;

namespace TestProject;

public class Part1Tests
{
    [Fact]
    public void IsValidDateOnlyString_DetectsValidDates()
    {
        // Arrange
        // store in a "year, month, day" format
        // expect a space character after the comma

        string input = "2024, 6, 15";

        // Act
        bool actual = DateStorage.IsValidDateOnlyString(input);

        // Assert
        Assert.True(actual);
    }

    // [Fact]
    // public void IsValidDateOnlyString_DetectsNonNumericCharactersInYear()
    // {
    //     // Arrange
    //     string input = "2y24, 6, 15";

    //     // Act
    //     bool actual = DateStorage.IsValidDateOnlyString(input);

    //     // Assert
    //     Assert.False(actual);
    // }

    // [Fact]
    // public void IsValidDateOnlyString_DetectsNonNumericCharactersInMonth()
    // {
    //     // Arrange
    //     string input = "2024, ;;;, 15";

    //     // Act
    //     bool actual = DateStorage.IsValidDateOnlyString(input);

    //     // Assert
    //     Assert.False(actual);
    // }

    // [Fact]
    // public void IsValidDateOnlyString_DetectsNonNumericCharactersInDay()
    // {
    //     // Arrange
    //     string input = "2024, 01, ^^%15";

    //     // Act
    //     bool actual = DateStorage.IsValidDateOnlyString(input);

    //     // Assert
    //     Assert.False(actual);
    // }

    // [Fact]
    // public void IsValidDateOnlyString_DetectsTooManyItems()
    // {
    //     // Arrange
    //     string input = "2024, 01, 15, 3";

    //     // Act
    //     bool actual = DateStorage.IsValidDateOnlyString(input);

    //     // Assert
    //     Assert.False(actual);
    // }

    // [Fact]
    // public void IsValidDateOnlyString_DetectsTooFew()
    // {
    //     // Arrange
    //     string input = "2024, 01";

    //     // Act
    //     bool actual = DateStorage.IsValidDateOnlyString(input);

    //     // Assert
    //     Assert.False(actual);
    // }

    // [Fact]
    // public void ParseDateOnly_CanParseValidDate_1()
    // {
    //     string input = "2024, 01, 15";

    //     DateOnly actual = DateStorage.ParseDateOnly(input);
    //     DateOnly expected = new DateOnly(2024, 01, 15);

    //     Assert.Equal(expected, actual);
    // }
    

    // [Fact]
    // public void ParseDateOnly_CanParseValidDate_2()
    // {
    //     string input = "2014, 10, 6";

    //     DateOnly actual = DateStorage.ParseDateOnly(input);
    //     DateOnly expected = new DateOnly(2014, 10, 6);

    //     Assert.Equal(expected, actual);
    // }

    // [Fact]
    // public void CreateDateOnlyStorageString_CanCreateCorrectString_1()
    // {
    //     DateOnly input = new DateOnly(2014, 10, 6);

    //     string actual = DateStorage.CreateDateOnlyStorageString(input);
    //     string expected = "2014, 10, 6";

    //     Assert.Equal(expected, actual);
    // }
    


    // [Fact]
    // public void CreateDateOnlyStorageString_CanCreateCorrectString_2()
    // {
    //     DateOnly input = new DateOnly(1985, 1, 1);

    //     string actual = DateStorage.CreateDateOnlyStorageString(input);
    //     string expected = "1985, 1, 1";

    //     Assert.Equal(expected, actual);
    // }
}