namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class B106_DrNeoCortex_BossLookAt_HandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public EigEaseType _LookAtTargetStartEaseType;
        [FieldAttr(nst: 44)] public float _LookAtTargetStartTime;
        [FieldAttr(nst: 48)] public float _LookAtTargetStartEaseRatioIn;
        [FieldAttr(nst: 52)] public float _LookAtTargetStartEaseRatioOut;
        [FieldAttr(nst: 56)] public bool _Bool;
    }
}
