namespace Alchemy
{
    [ObjectAttr(nst: 592, ctr: 560, align: 16)]
    public class igVfxDrawTrailOperator : igVfxDrawProcGeometryOperator
    {
        public enum ERolloutMethod
        {
            kDrag = 0,
            kStretch = 1,
            kWipe = 2,
            kRoll = 3,
        }

        [ObjectAttr(size: 4)]
        public class TrailFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public EModulation _widthAlongTrailModulation = EModulation.kModulate;
            [FieldAttr(offset: 3, size: 3)] public EModulation _colorAlongTrailModulation = EModulation.kReplace;
            [FieldAttr(offset: 6, size: 3)] public EModulation _alphaAlongTrailModulation = EModulation.kReplace;
            [FieldAttr(offset: 9, size: 3)] public igVfxDrawTrailOperator.ERolloutMethod _rolloutMethod;
            [FieldAttr(offset: 12, size: 3)] public int _trailBezier = 0;
            [FieldAttr(offset: 15, size: 6)] public int _trailSegmentCount = 0;
            [FieldAttr(offset: 21, size: 1)] public bool _banner;
            [FieldAttr(offset: 22, size: 1)] public bool _forceExactLength = false;
            [FieldAttr(offset: 23, size: 1)] public bool _isBillboard;
        }

        [FieldAttr(nst: 80, ctr: 60)] public TrailFlags _trailFlags = new();
        [FieldAttr(nst: 84, ctr: 64)] public uint _instanceData;
        [FieldAttr(nst: 88, ctr: 68)] public igRangedFloatMetaField _trailLength = new();
        [FieldAttr(nst: 96, ctr: 76)] public igVfxRangedCurveMetaField _widthAlongTrail = new();
        [FieldAttr(nst: 192, ctr: 160)] public igVfxRgbCurveMetaField _colorAlongTrail = new();
        [FieldAttr(nst: 464, ctr: 432)] public igVfxRangedCurveMetaField _alphaAlongTrail = new();
        [FieldAttr(nst: 560, ctr: 528)] public igVec3fAlignedMetaField _sideAxis = new();
        [FieldAttr(nst: 576, ctr: 544)] public EReferenceFrame _frame;
    }
}
