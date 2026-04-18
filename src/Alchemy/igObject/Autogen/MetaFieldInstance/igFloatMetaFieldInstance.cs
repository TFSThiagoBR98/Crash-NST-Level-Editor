namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class igFloatMetaFieldInstance : igMetaFieldInstance
    {
        [FieldAttr(nst: 56, ctr: 48, refCount: false)] public InlinedMemoryRef<float> _default = new();
    }
}
