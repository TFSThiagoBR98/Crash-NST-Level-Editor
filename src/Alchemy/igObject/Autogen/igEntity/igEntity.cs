namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class igEntity : igObject
    {
        public enum ENetworkSpawnAuthority
        {
            kLocalAuthority = 0,
            kHostAuthority = 1,
            kNoAuthority = 2,
            kParentAuthority = 3,
        }

        [ObjectAttr(size: 4)]
        public class Bitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _canSpawn;
            [FieldAttr(offset: 1, size: 1)] public bool _isArchetype;
            [FieldAttr(offset: 2, size: 1)] public bool _spawned;
            [FieldAttr(offset: 3, size: 4)] public uint _disableStack;
            [FieldAttr(offset: 7, size: 1)] public bool _enabledByVisualScript;
            [FieldAttr(offset: 8, size: 1)] public bool _enabled;
            [FieldAttr(offset: 9, size: 1)] public bool _isFading;
            [FieldAttr(offset: 10, size: 1)] public bool _isPositionDirty;
            [FieldAttr(offset: 11, size: 1)] public bool _isRotationDirty;
            [FieldAttr(offset: 12, size: 1)] public bool _isScaleDirty;
            [FieldAttr(offset: 13, size: 1)] public bool _isMoving;
            [FieldAttr(offset: 14, size: 1)] public bool _isVisible;
            [FieldAttr(offset: 15, size: 1)] public bool _isHidden;
            [FieldAttr(offset: 16, size: 1)] public bool _isVolumeCulled;
            [FieldAttr(offset: 17, size: 1)] public bool _canVolumeCull;
            [FieldAttr(offset: 18, size: 5)] public uint _disableVolumeCullStack;
            [FieldAttr(offset: 23, size: 1)] public bool _disableVolumeCullByScript;
            [FieldAttr(offset: 24, size: 1)] public bool _netHasAuthority;
            [FieldAttr(offset: 25, size: 7)] public int _userFlags;
        }

        [FieldAttr(nst: 16, ctr: 16)] public igEntityBolt? _bolt;
        [FieldAttr(nst: 24, ctr: 24)] public igComponentList? _components;
        [FieldAttr(nst: 32, ctr: 32)] public igVec3fMetaField _parentSpacePosition = new();
        [FieldAttr(nst: 48, ctr: 48)] public igEntityTransform? _transform;
        [FieldAttr(nst: 56, ctr: 56)] public Bitfield _bitfield = new();
        [FieldAttr(nst: 64, ctr: 64)] public igEntityData? _entityData;
    }
}
