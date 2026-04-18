namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CDynamicCheckpointComponentData : CEntityComponentData
    {
        [ObjectAttr(size: 1)]
        public class Storage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _triggerOnEnter;
            [FieldAttr(offset: 1, size: 1)] public bool _triggerOnDamage;
            [FieldAttr(offset: 2, size: 1)] public bool _triggerOnDeath;
        }

        [FieldAttr(nst: 24)] public bool _startEnabled = true;
        [FieldAttr(nst: 32)] public CCameraBase? _camera;
        [FieldAttr(nst: 40)] public igHandleMetaField _checkpoint = new();
        [FieldAttr(nst: 48)] public igVec3fMetaField _dynamicCheckpointOffset = new();
        [FieldAttr(nst: 60)] public Storage _storage = new();
    }
}
