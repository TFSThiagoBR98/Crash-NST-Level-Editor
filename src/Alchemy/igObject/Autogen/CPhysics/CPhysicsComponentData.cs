namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class CPhysicsComponentData : CBasePhysicsComponentData
    {
        public enum EScaleMode
        {
            eSM_NoScaling = 0,
            eSM_ScaleCollisionOnSpawnOnly = 1,
            eSM_ScaleCollisionWhenChanged = 2,
        }

        [FieldAttr(nst: 24, ctr: 16)] public EHavokEntityType _motionType = EHavokEntityType.eHET_Fixed;
        [FieldAttr(nst: 28, ctr: 20)] public float _mass = 1.0f;
        [FieldAttr(nst: 32, ctr: 24)] public ETeamFilterLayers _collisionLayer = ETeamFilterLayers.eTFL_Entity;
        [FieldAttr(nst: 40, ctr: 32)] public igHandleMetaField _collisionMaterial = new();
        [FieldAttr(nst: 48, ctr: 40)] public igHandleMetaField _motionProperties = new();
        [FieldAttr(nst: 56, ctr: 48)] public ECharacterCollisionPriority _collisionPriority = ECharacterCollisionPriority.eCCP_None;
        [FieldAttr(nst: 60, ctr: 52)] public EScaleMode _scaleMode = CPhysicsComponentData.EScaleMode.eSM_ScaleCollisionOnSpawnOnly;
        [FieldAttr(nst: 64, ctr: 56)] public bool _useMaxStepAcceleration;
        [FieldAttr(nst: 68, ctr: 60)] public float _bodyLookAheadDistance;
    }
}
