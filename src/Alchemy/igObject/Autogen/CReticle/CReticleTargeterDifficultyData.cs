namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4)]
    public class CReticleTargeterDifficultyData : igObject
    {
        [FieldAttr(nst: 16)] public float _easyPrimaryReticleScale = 1.0f;
        [FieldAttr(nst: 20)] public igVec2fMetaField _easyBoxAcquireTargetingExtents = new();
        [FieldAttr(nst: 28)] public igVec2fMetaField _easyBoxDropTargetingExtents = new();
        [FieldAttr(nst: 36)] public float _easyCircleAcquireTargetingRadius = 120.0f;
        [FieldAttr(nst: 40)] public float _easyCircleDropTargetingRadius = 240.0f;
        [FieldAttr(nst: 44)] public float _mediumPrimaryReticleScale = 1.0f;
        [FieldAttr(nst: 48)] public igVec2fMetaField _mediumBoxAcquireTargetingExtents = new();
        [FieldAttr(nst: 56)] public igVec2fMetaField _mediumBoxDropTargetingExtents = new();
        [FieldAttr(nst: 64)] public float _mediumCircleAcquireTargetingRadius = 120.0f;
        [FieldAttr(nst: 68)] public float _mediumCircleDropTargetingRadius = 240.0f;
        [FieldAttr(nst: 72)] public float _hardPrimaryReticleScale = 1.0f;
        [FieldAttr(nst: 76)] public igVec2fMetaField _hardBoxAcquireTargetingExtents = new();
        [FieldAttr(nst: 84)] public igVec2fMetaField _hardBoxDropTargetingExtents = new();
        [FieldAttr(nst: 92)] public float _hardCircleAcquireTargetingRadius = 120.0f;
        [FieldAttr(nst: 96)] public float _hardCircleDropTargetingRadius = 240.0f;
        [FieldAttr(nst: 100)] public float _nightmarePrimaryReticleScale = 1.0f;
        [FieldAttr(nst: 104)] public igVec2fMetaField _nightmareBoxAcquireTargetingExtents = new();
        [FieldAttr(nst: 112)] public igVec2fMetaField _nightmareBoxDropTargetingExtents = new();
        [FieldAttr(nst: 120)] public float _nightmareCircleAcquireTargetingRadius = 120.0f;
        [FieldAttr(nst: 124)] public float _nightmareCircleDropTargetingRadius = 240.0f;
    }
}
