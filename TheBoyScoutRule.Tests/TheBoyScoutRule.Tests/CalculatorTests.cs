namespace TheBoyScoutRule.Tests;

public class CalculatorTests
{
    [Fact]
    public void CalculateBonus_WhenEmployeeIsDeveloperAndOver25YearsOld_ReturnsCorrectBonus()
    {
        // Arrange
        Calculator calculator = new Calculator();
        int salary = 1000;
        string employeeType = "Developer";
        int employeeAge = 26;

        // Act
        double result = calculator.CalculateBonus(salary, employeeType, employeeAge);

        // Assert
        Assert.Equal(500, result);
    }
}