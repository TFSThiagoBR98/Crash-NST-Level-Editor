namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiOctaneLoadingScreenHint : igObject
    {
        [FieldAttr(ctr: 16)] public string? _hintName;
        [FieldAttr(ctr: 24)] public string? _hintText;
    }
}
