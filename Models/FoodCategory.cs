namespace FoodApp.Models;

public class FoodCategory : IEquatable<FoodCategory>
{
    // TODO: i18n, dk, en
    public string? Name { get; set; }

    public bool Equals(FoodCategory? other)
    {
        if (other == null)
            return false;

        if (this.Name == other.Name)
            return true;
        else
            return false;
    }
}