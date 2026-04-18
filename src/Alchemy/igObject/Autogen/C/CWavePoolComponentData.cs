namespace Alchemy
{
    [ObjectAttr(nst: 176, align: 8)]
    public class CWavePoolComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public float _collisionWaveHeightInfluenceMax = 2.0f;
        [FieldAttr(nst: 28)] public float _wave1Angle = 50.0f;
        [FieldAttr(nst: 32)] public float _wave1Length = 3600.0f;
        [FieldAttr(nst: 36)] public float _wave1Speed = 690.0f;
        [FieldAttr(nst: 40)] public float _wave1Amplitude = 12.0f;
        [FieldAttr(nst: 44)] public float _wave2Angle = 125.0f;
        [FieldAttr(nst: 48)] public float _wave2Length = 2670.0f;
        [FieldAttr(nst: 52)] public float _wave2Speed = 560.0f;
        [FieldAttr(nst: 56)] public float _wave2Amplitude = 12.0f;
        [FieldAttr(nst: 60)] public float _restingWaterHeightOffset;
        [FieldAttr(nst: 64)] public CWaypoint? _splash1Origin;
        [FieldAttr(nst: 72)] public float _splash1Length = 600.0f;
        [FieldAttr(nst: 76)] public float _splash1Speed = 690.0f;
        [FieldAttr(nst: 80)] public float _splash1Amplitude = 50.0f;
        [FieldAttr(nst: 84)] public float _splash1Radius = 6000.0f;
        [FieldAttr(nst: 88)] public CWaypoint? _splash2Origin;
        [FieldAttr(nst: 96)] public float _splash2Length = 600.0f;
        [FieldAttr(nst: 100)] public float _splash2Speed = 690.0f;
        [FieldAttr(nst: 104)] public float _splash2Amplitude = 50.0f;
        [FieldAttr(nst: 108)] public float _splash2Radius = 6000.0f;
        [FieldAttr(nst: 112)] public CWaypointList? _splashOriginList;
        [FieldAttr(nst: 120)] public bool _autoGenerateRandomSplashes;
        [FieldAttr(nst: 124)] public igRangedFloatMetaField _randomSplashLength = new();
        [FieldAttr(nst: 132)] public igRangedFloatMetaField _randomSplashSpeed = new();
        [FieldAttr(nst: 140)] public igRangedFloatMetaField _randomSplashAmplitude = new();
        [FieldAttr(nst: 148)] public igRangedFloatMetaField _randomSplashRadius = new();
        [FieldAttr(nst: 156)] public igRangedFloatMetaField _randomSplashDecreaseTime = new();
        [FieldAttr(nst: 164)] public bool _debug;
        [FieldAttr(nst: 168)] public igHandleMetaField _splashVfx = new();
    }
}
