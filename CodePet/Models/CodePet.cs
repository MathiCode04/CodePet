namespace WebApplication2.Models; // Organisiert die Klassen in einem Namensraum.

public class CodePet // Definiert das Modell für unser virtuelles Haustier.
{
    public string Name { get; set; } = "Bitzi"; // Name des Haustiers, Standardwert "Bitzi".
    public int Hunger { get; set; } = 5; // Hungerwert: 0 = satt, 10 = verhungert.
    public string Stimmung // Berechnete Eigenschaft für die Stimmung basierend auf dem Hunger.
    {
        get
        {
            if (Hunger <= 3) return "😊"; // Wenig Hunger = glücklich.
            if (Hunger <= 6) return "😐"; // Mittlerer Hunger = neutral.
            return "😢"; // Viel Hunger = traurig.
        }
    }
}