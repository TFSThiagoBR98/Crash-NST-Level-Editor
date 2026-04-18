namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 16)]
    public class igGuiAsset : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _name = null;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igGuiAsset? _sourceAsset;
    }
}
