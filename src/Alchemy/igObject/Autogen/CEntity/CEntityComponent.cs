namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class CEntityComponent : igComponent
    {
        [ObjectAttr(size: 1)]
        public class PropertyStorage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _isInitialized;
            [FieldAttr(offset: 1, size: 1)] public bool _isPersistent;
        }

        [FieldAttr(nst: 40, ctr: 36)] public PropertyStorage _propertyStorage = new();
    }
}
