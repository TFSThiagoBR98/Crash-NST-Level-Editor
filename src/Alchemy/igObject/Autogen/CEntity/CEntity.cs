namespace Alchemy
{
    [ObjectAttr(nst: 144, ctr: 144, align: 8)]
    public class CEntity : igEntity
    {
        public enum EScaleSource
        {
            eSS_Entity = 0,
            eSS_EntityData = 1,
        }

        [ObjectAttr(size: 2)]
        public class Properties : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _startHidden;
            [FieldAttr(offset: 1, size: 1)] public bool _haveComponentsToStart;
            [FieldAttr(offset: 2, size: 1)] public bool _haveComponentsToRemove;
            [FieldAttr(offset: 3, size: 1)] public bool _actEnabled;
            [FieldAttr(offset: 4, size: 1)] public bool _actToggleOn = false;
            [FieldAttr(offset: 5, size: 1)] public CEntity.EScaleSource _scaleSource;
            [FieldAttr(offset: 6, size: 1)] public bool netReplicate;
            [FieldAttr(offset: 7, size: 1)] public bool hasTimeComponent;
            [FieldAttr(offset: 8, size: 1)] public bool hasScaledTimeComponent;
            [FieldAttr(offset: 9, size: 1)] public bool _netShouldSyncOnJip;
            [FieldAttr(offset: 10, size: 1)] public bool _teamIsDirty;
        }

        [FieldAttr(nst: 72, ctr: 72)] public igVec3fMetaField _min = new();
        [FieldAttr(nst: 84, ctr: 84)] public igVec3fMetaField _max = new();
        [FieldAttr(nst: 96, ctr: 96)] public igVec3fMetaField _velocity = new();
        [FieldAttr(nst: 108, ctr: 108)] public igVec3fMetaField _angularVelocity = new();
        [FieldAttr(nst: 120, ctr: 120)] public uint _flags;
        [FieldAttr(nst: 128, ctr: 128)] public string? _name = null;
        [FieldAttr(nst: 136, ctr: 136)] public CEntityIDMetaField _id = new();
        [FieldAttr(nst: 140, ctr: 140)] public Properties _properties = new();
        [FieldAttr(nst: 142, ctr: 142)] public i16 _turningLockedCounter;
    }
}
