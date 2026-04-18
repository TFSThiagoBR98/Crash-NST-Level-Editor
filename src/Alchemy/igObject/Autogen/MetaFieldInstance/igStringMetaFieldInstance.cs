namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class igStringMetaFieldInstance : igRefMetaFieldInstance
    {
        [FieldAttr(nst: 56, ctr: 48, refCount: false)] public igMemoryRef<string?> _default = new();
    }
}
