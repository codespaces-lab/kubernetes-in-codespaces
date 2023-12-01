using Xunit;

public class LocationTests
{
    [Fact]
    public void Parse_ValidInput_ReturnsLocation()
    {
        // Arrange
        string input = "101102.004005006777888999";

        // Act
        Location result = Location.Parse(input);

        


        // Assert
        Assert.NotNull(result);
        Assert.Equal(input, result.Latitude);
        Assert.Equal(0.0, result.Longitude);
    }
}