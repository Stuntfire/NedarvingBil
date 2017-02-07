namespace NedarvingBil
{
    public interface IElBil
    {
        int BatteriKapacitet { get; set; }
        int KmPrKw { get; set; }
        int LadeTid { get; set; }

        int GetRegistreringsAfgift();
        int GetRækkeVidde();
        int HalvÅrligEjerafgift();
        string HvilkenBilErJeg();
        string ToString();
    }
}