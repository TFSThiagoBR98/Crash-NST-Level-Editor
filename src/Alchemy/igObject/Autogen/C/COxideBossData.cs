namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class COxideBossData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _oxideFirstMovieName;
        [FieldAttr(ctr: 24)] public string? _oxideSecondMovieName;
    }
}
