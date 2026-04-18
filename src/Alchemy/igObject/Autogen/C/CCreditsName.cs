namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CCreditsName : igObject
    {
        [FieldAttr(ctr: 16)] public string? _devName;
        [FieldAttr(ctr: 24)] public string? _devTitle;
    }
}
