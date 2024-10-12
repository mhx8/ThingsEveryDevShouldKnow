namespace BeforeYouRefactor.Tests;

public class CalculatorTests
{
    private readonly Calculator _sut = new();

    [Fact]
    public void Calculator_WhenEmployeeAgeIsLessThan25_ShouldReturnNoBonus()
    {
        // Arrange
        const int salary = 1000;
        const string employeeType = "Manager";
        const int employeeAge = 24;

        // Act
        double result = _sut.CalculateBonus(salary, employeeType, employeeAge);

        // Assert
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData(1000, "Manager", 200)]
    [InlineData(1000, "Sales", 400)]
    [InlineData(1000, "Developer", 500)]
    [InlineData(1000, "Default", 100)]
    public void CalculateBonus_ShouldReturnCorrectBonus(
        double salary,
        string employeeType,
        double expectedBonus)
    {
        // Act
        double actualBonus = _sut.CalculateBonus(salary, employeeType, 35);

        // Assert 
        Assert.Equal(expectedBonus, actualBonus);
    }
    
}