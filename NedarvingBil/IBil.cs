namespace NedarvingBil
{
    public interface IBil
    {
        int BilPrisExAfgift { get; }
        int KøbsÅr { get; }
        string Mærke { get; set; }
        int RegistreringsAfgift { get; set; }
        string RegistreringsNr { get; set; }

        int GetRegistreringsAfgift();
        int GetRækkeVidde();
        int HalvÅrligEjerafgift();
        string HvilkenBilErJeg();
        int TotalPris();
    }
}