// Enums
/*
    Enumima program cinimo citljivijim
    Osnovni type Enuma je int
    Default value prvog enuma je 0


    to get Enums Values and Names we used Enum.GetValue & Enum.GetNames
*/

// #21
// short --> MaxValue = 32767 ; MinValue = -32767
public enum Gender //: short
{
    Unknown, // kada bi napisali Unknown = 1 to znaci da je ta vrijednost u Enumu na indeksu 1
    Male,    // kada bi napisali Male = 5 to znaci da postavljamo tu vrijednost u Enumu na indeks 5
    Female
}

public enum Season
{
    Winter = 1,
    Spring = 2,
    Summer = 3
}

public class EnumClass
{
    // #21
    public static string GetGender(Gender gender)
    {
        switch (gender)
        {
            case Gender.Unknown:
                return "Unknown";

            case Gender.Male:
                return "Male";

            case Gender.Female:
                return "Female";

            default:
                return "Invalid data detected";
        }
    }
}
