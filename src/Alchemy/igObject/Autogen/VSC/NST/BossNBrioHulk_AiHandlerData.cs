namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNBrioHulk_AiHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _BossNBrioHulkDamageData = new();
        [FieldAttr(nst: 48)] public float _ChargeMoveXDistanceMax;
        [FieldAttr(nst: 52)] public float _ChargeWidth;
        [FieldAttr(nst: 56)] public float _ReturnTime;
        [FieldAttr(nst: 60)] public float _ReturnJumpHeight;
        [FieldAttr(nst: 64)] public float _ChargePlayerAdjustYRangeStrength;
        [FieldAttr(nst: 68)] public float _ChargePlayerDistanceMin;
        [FieldAttr(nst: 72)] public float _ChargePlayerYAheadOffset;
        [FieldAttr(nst: 76)] public float _Float_0x4c;
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 84)] public float _Float_0x54;
    }
}
