namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class B106_DrNeoCortex_BossHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _BossStageList = new();
        [FieldAttr(nst: 48)] public float _IntroBehaviorDelayStart;
        [FieldAttr(nst: 52)] public int _Int;
        [FieldAttr(nst: 56)] public float _Float;
    }
}
