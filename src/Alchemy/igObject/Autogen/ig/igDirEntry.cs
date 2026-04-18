namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igDirEntry : igNamedObject
    {
        [FieldAttr(ctr: 24)] public int _index;
        [FieldAttr(ctr: 32)] public igRawRefMetaField _ref = new();
    }
}
