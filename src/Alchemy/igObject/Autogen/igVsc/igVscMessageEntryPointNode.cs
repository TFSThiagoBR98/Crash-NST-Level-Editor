namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 8)]
    public class igVscMessageEntryPointNode : igVscEntryPointNode
    {
        [FieldAttr(nst: 56, ctr: 56)] public igVectorMetaField<igMetaFieldInstance> _metaFields = new();
    }
}
