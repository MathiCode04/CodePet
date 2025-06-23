namespace WebApplication2.Models;

public class CodePet {
    public string Name { get; set; } = "Bitzi";
    public int Hunger { get; set; } = 5; // 0 = satt, 10 = verhungert
    public string Stimmung {
        get {
            if (Hunger <= 3) return "😊";
            if (Hunger <= 6) return "😐";
            return "😢";
        }
    }
}
