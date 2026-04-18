namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class COctaneGameModeFilter : igObject
    {
        [FieldAttr(ctr: 16)] public string? _filter;
        [FieldAttr(ctr: 24)] public COctaneRaceModesList? _validGameModes;
    }
}
