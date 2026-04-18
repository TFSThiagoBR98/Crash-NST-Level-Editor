namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class igModelMaterialRedirectTable : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVectorMetaField<igHandleMetaFieldInstance> _sourceHandles = new();
        [FieldAttr(nst: 40, ctr: 40)] public igVectorMetaField<igHandleMetaFieldInstance> _targetHandles = new();
        [FieldAttr(nst: 64, ctr: 64)] public igHandleMetaField _defaultRedirectHandle = new();
    }
}
