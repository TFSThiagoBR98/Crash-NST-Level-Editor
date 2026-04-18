namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class common_C1_BossCortex_BlueHazardData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _DamageData = new();
        [FieldAttr(nst: 48)] public EigEaseType _BobEaseType;
        [FieldAttr(nst: 52)] public float _BobEaseRatioIn;
        [FieldAttr(nst: 56)] public float _BobEaseRatioOut;
        [FieldAttr(nst: 60)] public float _BobZOffset;
        [FieldAttr(nst: 64)] public float _BobSpeed;
    }
}
