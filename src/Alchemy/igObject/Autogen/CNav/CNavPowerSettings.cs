namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 4)]
    public class CNavPowerSettings : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public uint _layer;
        [FieldAttr(nst: 20, ctr: 16)] public float _voxelSize = 12.0f;
        [FieldAttr(nst: 24, ctr: 20)] public float _verticalOffset = 12.0f;
        [FieldAttr(nst: 28, ctr: 24)] public float _characterRadius = 50.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _characterHeight = 250.0f;
        [FieldAttr(nst: 36, ctr: 32)] public float _dropOffRadius = 50.0f;
        [FieldAttr(nst: 40, ctr: 36)] public float _stepHeight = 16.0f;
        [FieldAttr(nst: 44, ctr: 40)] public float _maxWalkableSlope = 45.0f;
        [FieldAttr(nst: 48, ctr: 44)] public bool _optimizeForAxisAligned;
        [FieldAttr(nst: 49, ctr: 45)] public bool _useEnhancedTerrainTracking;
        [FieldAttr(nst: 50, ctr: 46)] public bool _enableLinkGeneration = true;
        [FieldAttr(nst: 52, ctr: 48)] public float _linkMinConnectDistance;
        [FieldAttr(nst: 56, ctr: 52)] public float _linkMaxConnectDistance = 150.0f;
        [FieldAttr(nst: 60, ctr: 56)] public float _linkMaxJumpUpDistance = 300.0f;
        [FieldAttr(nst: 64, ctr: 60)] public float _linkMaxJumpDownDistance = 750.0f;
        [FieldAttr(nst: 68, ctr: 64)] public float _linkMaxConnectAngle = 60.0f;
        [FieldAttr(nst: 72, ctr: 68)] public float _linkProbeHeight = 200.0f;
        [FieldAttr(nst: 76, ctr: 72)] public float _linkHighJumpThreshold = 175.0f;
    }
}
