namespace Alchemy
{
    [ObjectAttr(nst: 272, ctr: 272, align: 16)]
    public class CWind2 : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CWindParameters2? _params;
        [FieldAttr(nst: 24, ctr: 24)] public CWindShaderConstantBundle[] _windConstantBundles = new CWindShaderConstantBundle[2];
        [FieldAttr(nst: 40, ctr: 40)] public igModelData? _associatedModelData;
        [FieldAttr(nst: 48, ctr: 48)] public igRandomMetaField _random = new();
        [FieldAttr(nst: 56, ctr: 56)] public float _strength;
        [FieldAttr(nst: 60, ctr: 60)] public igVec3fMetaField _direction = new();
        [FieldAttr(nst: 72, ctr: 72)] public bool _allowGusting = true;
        [FieldAttr(nst: 76, ctr: 76)] public float _currentTime;
        [FieldAttr(nst: 80, ctr: 80)] public float _lastTime = -1.0f;
        [FieldAttr(nst: 84, ctr: 84)] public float _elapsedTime;
        [FieldAttr(nst: 88, ctr: 88)] public float _strengthTarget;
        [FieldAttr(nst: 92, ctr: 92)] public float _strengthChangeStartTime;
        [FieldAttr(nst: 96, ctr: 96)] public float _strengthChangeEndTime;
        [FieldAttr(nst: 100, ctr: 100)] public float _strengthAtStart;
        [FieldAttr(nst: 104, ctr: 104)] public igVec3fMetaField _directionTarget = new();
        [FieldAttr(nst: 116, ctr: 116)] public igVec3fMetaField _directionAtStart = new();
        [FieldAttr(nst: 128, ctr: 128)] public igVec3fMetaField _directionMidTarget = new();
        [FieldAttr(nst: 140, ctr: 140)] public float _directionChangeStartTime;
        [FieldAttr(nst: 144, ctr: 144)] public float _directionChangeEndTime;
        [FieldAttr(nst: 148, ctr: 148)] public float _gust;
        [FieldAttr(nst: 152, ctr: 152)] public float _gustTarget;
        [FieldAttr(nst: 156, ctr: 156)] public float _gustRiseTarget;
        [FieldAttr(nst: 160, ctr: 160)] public float _gustFallTarget;
        [FieldAttr(nst: 164, ctr: 164)] public float _gustStart;
        [FieldAttr(nst: 168, ctr: 168)] public float _gustAtStart = 1.0f;
        [FieldAttr(nst: 172, ctr: 172)] public float _gustFallStart;
        [FieldAttr(nst: 176, ctr: 176)] public float _combinedStrength;
        [FieldAttr(nst: 180, ctr: 180)] public float[] _oscillationTimes = new float[10];
        [FieldAttr(nst: 224, ctr: 224)] public igVec4fMetaField _windGlobal = new();
        [FieldAttr(nst: 240, ctr: 240)] public igVec4fMetaField _windVector = new();
        [FieldAttr(nst: 256, ctr: 256)] public float _globalDirectionAdherence;
        [FieldAttr(nst: 264, ctr: 264)] public CWind2? _windLeader;
    }
}
