namespace Alchemy
{
    [ObjectAttr(nst: 440, ctr: 432, align: 8)]
    public class CVfxDrawForceOperator : igVfxDrawOperator
    {
        [ObjectAttr(size: 2)]
        public class SurfaceFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _spawnLayer1 = true;
            [FieldAttr(offset: 1, size: 1)] public bool _spawnLayer2 = false;
            [FieldAttr(offset: 2, size: 1)] public bool _spawnLayer3 = false;
            [FieldAttr(offset: 3, size: 1)] public bool _spawnLayer4 = false;
            [FieldAttr(offset: 4, size: 1)] public bool _spawnLayer5 = false;
            [FieldAttr(offset: 5, size: 1)] public bool _spawnLayer6 = false;
            [FieldAttr(offset: 6, size: 1)] public bool _spawnLayer7 = false;
            [FieldAttr(offset: 7, size: 1)] public bool _spawnLayer8 = false;
            [FieldAttr(offset: 8, size: 1)] public bool _spawnLayer9 = false;
            [FieldAttr(offset: 9, size: 1)] public bool _spawnLayer10 = false;
            [FieldAttr(offset: 10, size: 1)] public bool _spawnLayer11 = false;
            [FieldAttr(offset: 11, size: 1)] public bool _spawnLayer12 = false;
            [FieldAttr(offset: 12, size: 1)] public bool _spawnLayer13 = false;
            [FieldAttr(offset: 13, size: 1)] public bool _spawnLayer14 = false;
            [FieldAttr(offset: 14, size: 1)] public bool _spawnLayer15 = false;
            [FieldAttr(offset: 15, size: 1)] public bool _spawnLayer16 = false;
        }

        [FieldAttr(nst: 32, ctr: 20)] public EDrawForceCoordinateSystem _coordinateSystem;
        [FieldAttr(nst: 36, ctr: 24)] public EDrawForceShapeType _shapeType;
        [FieldAttr(nst: 40, ctr: 28)] public igVfxRangedCurveMetaField _magnitudeT = new();
        [FieldAttr(nst: 124, ctr: 112)] public EOperatorCurveInput _magnitudeInput;
        [FieldAttr(nst: 128, ctr: 116)] public igVfxRangedCurveMetaField _magnitudeA = new();
        [FieldAttr(nst: 212, ctr: 200)] public igVfxRangedCurveMetaField _magnitudeB = new();
        [FieldAttr(nst: 296, ctr: 284)] public igVfxRangedCurveMetaField _magnitudeC = new();
        [FieldAttr(nst: 380, ctr: 368)] public uint _collisionFlags = 64;
        [FieldAttr(nst: 384, ctr: 372)] public SurfaceFlags _surfaceFlags = new();
        [FieldAttr(nst: 388, ctr: 376)] public float _tumbleFraction;
        [FieldAttr(nst: 392, ctr: 380)] public float _massFactor = 1.0f;
        [FieldAttr(nst: 396, ctr: 384)] public float _maxLinearSpeed = -1.0f;
        [FieldAttr(nst: 400, ctr: 388)] public float _maxAngularSpeed = -1.0f;
        [FieldAttr(nst: 404, ctr: 392)] public bool _impulse;
        [FieldAttr(nst: 405, ctr: 393)] public bool _ignoreBoltEntity;
        [FieldAttr(nst: 408, ctr: 396)] public EDrawForceRangeCorrelation _rangeCorrelation;
        [FieldAttr(nst: 412, ctr: 400)] public uint _instance;
        [FieldAttr(nst: 416, ctr: 408)] public CHavokShapeMetaField _cachedShape = new();
        [FieldAttr(nst: 424, ctr: 416)] public igVec3fMetaField _cachedShapeBounds = new();
    }
}
