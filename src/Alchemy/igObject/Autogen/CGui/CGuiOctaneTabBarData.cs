namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiOctaneTabBarData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _pageName;
        [FieldAttr(ctr: 24)] public bool _visible;
    }
}
