namespace FoodApp.Models;

public class Food
{

    public Food()
    {
        Unit = "kg";
    }
    public int Id { get; set; }
    public string? Name { get; set; }
    // TODO: i18n, dk, en
    public string? DisplayName { get; set; }
    public string? ExternalId { get; set; }

    public string? CategoryName { get; set; }
    public FoodCategory? Category { get; set; }
    public string Unit { get; set; }
    public float EmissionAgriculture { get; set; }
    public float EmissionILUC { get; set; }
    public float EmissionFoodProcessing { get; set; }
    public float EmissionPackaging { get; set; }
    public float EmissionTransport { get; set; }
    public float EmissionRetail { get; set; }
    public float? EmissionTotal { get; set; }
    int MacroKilojoules { get; set; }
    float MacroFat { get; set; }
    float MacroCarbohydrates { get; set; }
    float MacroProtein { get; set; }
}