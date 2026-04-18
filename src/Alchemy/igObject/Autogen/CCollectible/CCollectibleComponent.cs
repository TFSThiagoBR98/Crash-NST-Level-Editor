namespace Alchemy
{
    [ObjectAttr(nst: 200, align: 8)]
    public class CCollectibleComponent : igComponent
    {
        [FieldAttr(nst: 40)] public COnCollectibleComponentCollectedDelegate? _onCollectBegin;
        [FieldAttr(nst: 48)] public COnCollectibleComponentCollectedEventList? _onCollectBeginEventList;
        [FieldAttr(nst: 56)] public COnCollectibleComponentCollectedDelegate? _onCollected;
        [FieldAttr(nst: 64)] public COnCollectibleComponentCollectedEventList? _onCollectedEventList;
        [FieldAttr(nst: 72)] public float _autoCollectTime = -1.0f;
        [FieldAttr(nst: 76)] public float _notCollectibleUntilTime;
        [FieldAttr(nst: 80)] public float _attractSpeed;
        [FieldAttr(nst: 84)] public float _startingZPosition;
        [FieldAttr(nst: 88)] public bool _watchToDisablePhysics;
        [FieldAttr(nst: 89)] public bool _forceAutoCollect;
        [FieldAttr(nst: 90)] public bool _collectionPaused;
        [FieldAttr(nst: 91)] public bool _attracting;
        [FieldAttr(nst: 92)] public bool _useAttractTargetPosition;
        [FieldAttr(nst: 96)] public igHandleMetaField _attractToActor = new();
        [FieldAttr(nst: 104)] public float _distanceWhenAttractionBegan;
        [FieldAttr(nst: 108)] public float _scaleWhenAttractionBegan;
        [FieldAttr(nst: 112)] public igVec3fMetaField _attractTargetPosition = new();
        [FieldAttr(nst: 124)] public float _attractRadiusWorldModifier = -1.0f;
        [FieldAttr(nst: 128)] public float _awardValueWorldModifier = -1.0f;
        [FieldAttr(nst: 132)] public float _alternateAwardValueWorldModifier = -1.0f;
        [FieldAttr(nst: 136)] public igHandleMetaField _idleVfx = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _trailVfx = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _collectBeginVfx = new();
        [FieldAttr(nst: 160)] public CHavokShapeMetaField _sphereShape = new();
        [FieldAttr(nst: 168)] public CHavokRigidBodyMetaField _rigidBody = new();
        [FieldAttr(nst: 184)] public CWorldCollectibleModifierItem? _modifierItem;
        [FieldAttr(nst: 192)] public bool _useAlternateAwardValue;
    }
}
