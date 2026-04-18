namespace Alchemy
{
    [ObjectAttr(nst: 1376, ctr: 1368, align: 8)]
    public class CWindParameters2 : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool[] _options = new bool[31];
        [FieldAttr(nst: 48, ctr: 44)] public float _strengthResponse = 5.0f;
        [FieldAttr(nst: 52, ctr: 48)] public float _directionResponse = 2.5f;
        [FieldAttr(nst: 56, ctr: 52)] public float _anchorOffset;
        [FieldAttr(nst: 60, ctr: 56)] public float _anchorDistanceScale = 1.0f;
        [FieldAttr(nst: 64, ctr: 60)] public float[] _frequencies = new float[100];
        [FieldAttr(nst: 464, ctr: 460)] public float _globalHeight = 50.0f;
        [FieldAttr(nst: 468, ctr: 464)] public float _globalHeightExponent = 2.0f;
        [FieldAttr(nst: 472, ctr: 468)] public float[] _globalDistance = new float[10];
        [FieldAttr(nst: 512, ctr: 508)] public float[] _globalDirectionAdherence = new float[10];
        [FieldAttr(nst: 552, ctr: 548)] public SBranchLevelMetaField[] _branch = new SBranchLevelMetaField[2];
        [FieldAttr(nst: 816, ctr: 812)] public float _rollingBranchesMaxScale = 1.0f;
        [FieldAttr(nst: 820, ctr: 816)] public float _rollingBranchesMinScale = 1.0f;
        [FieldAttr(nst: 824, ctr: 820)] public float _rollingBranchesSpeed = 0.3f;
        [FieldAttr(nst: 828, ctr: 824)] public float _rollingBranchesRipple = 5.0f;
        [FieldAttr(nst: 832, ctr: 828)] public float _maxBranchLevel1Length = 10.0f;
        [FieldAttr(nst: 836, ctr: 832)] public igVec3fMetaField _branchWindAnchor = new();
        [FieldAttr(nst: 848, ctr: 844)] public SLeafGroupMetaField[] _leaf = new SLeafGroupMetaField[2];
        [FieldAttr(nst: 1296, ctr: 1292)] public float[] _frondRippleDistance = new float[10];
        [FieldAttr(nst: 1336, ctr: 1332)] public float _frondRippleTile = 10.0f;
        [FieldAttr(nst: 1340, ctr: 1336)] public float _frondRippleLightingScalar = 1.0f;
        [FieldAttr(nst: 1344, ctr: 1340)] public float _gustFrequency;
        [FieldAttr(nst: 1348, ctr: 1344)] public float _gustStrengthMin = 0.5f;
        [FieldAttr(nst: 1352, ctr: 1348)] public float _gustStrengthMax = 1.0f;
        [FieldAttr(nst: 1356, ctr: 1352)] public float _gustDurationMin = 1.0f;
        [FieldAttr(nst: 1360, ctr: 1356)] public float _gustDurationMax = 4.0f;
        [FieldAttr(nst: 1364, ctr: 1360)] public float _gustRiseScalar = 1.0f;
        [FieldAttr(nst: 1368, ctr: 1364)] public float _gustFallScalar = 1.0f;
    }
}
