namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNBrio_HulkPlatformHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public EigEaseType _SpawnInScaleEaseType;
        [FieldAttr(nst: 44)] public EigEaseType _FallEaseType;
        [FieldAttr(nst: 48)] public float _FallTime;
        [FieldAttr(nst: 52)] public float _FallEaseRatioIn;
        [FieldAttr(nst: 56)] public float _FallEaseRatioOut;
        [FieldAttr(nst: 60)] public float _SpawnInScaleTime;
        [FieldAttr(nst: 64)] public float _SpawnInScaleEaseRatioIn;
        [FieldAttr(nst: 68)] public float _SpawnInScaleEaseRatioOut;
        [FieldAttr(nst: 72)] public float _VfxFallImpactSpawnOnFallTimeRatio;
        [FieldAttr(nst: 80)] public igHandleMetaField _VfxFallImpactData = new();
    }
}
