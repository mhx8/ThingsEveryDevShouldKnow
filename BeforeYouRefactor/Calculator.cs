namespace BeforeYouRefactor;

public class Calculator
{
    private const string Developer = "Developer";
    private const double DeveloperBonusFactor = 0.5;
    private const string Manager = "Manager";
    private const string Sales = "Sales";
    private const double ManagerBonusFactor = 0.2;
    private const double SalesBonusFactor = 0.4;
    private const double DefaultBonusFactor = 0.1;
    private const int MinimumAgeForBonus = 25;

    public double CalculateBonus(double salary, string employeeType, int employeeAge)
    {
        if (employeeAge <= MinimumAgeForBonus) return 0;
        
        return employeeType switch
        {
            Manager => salary * ManagerBonusFactor,
            Sales => salary * SalesBonusFactor,
            Developer => salary * DeveloperBonusFactor,
            _ => salary * DefaultBonusFactor
        };

    }
}