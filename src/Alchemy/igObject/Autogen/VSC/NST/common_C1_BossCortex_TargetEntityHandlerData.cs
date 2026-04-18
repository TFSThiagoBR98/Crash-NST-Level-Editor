namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_C1_BossCortex_TargetEntityHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _IsDestroySelfOnMoveToXOffsetDone;
        [FieldAttr(nst: 48)] public igHandleMetaField _BlueHazardTemplate = new();
        [FieldAttr(nst: 56)] public float _MoveToXOffset;
        [FieldAttr(nst: 60)] public float _MoveToXOffsetSpeed;
    }
}
