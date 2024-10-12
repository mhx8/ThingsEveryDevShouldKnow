namespace TheBoyScoutRule;

public class Calculator
{
    private const string Developer = "Developer";
    private const double DeveloperBonusFactor = 0.5;

    public double CalculateBonus(double salary, string employeeType, int employeeAge)
    {
        // Wenn der Mitarbeiter über 25 Jahre alt ist, bekommt er einen Bonus
        if (employeeAge > 25)
        {
            if (employeeType == "Manager")
            {
                return salary * 0.2;
            }
            else if (employeeType == "Sales")
            {
                return salary * 0.4;
            }
            else if (employeeType == Developer)
            {
                return salary * DeveloperBonusFactor;
            }
            else
            {
                return salary * 0.1;
            }
        }

        return 0;
    }
}