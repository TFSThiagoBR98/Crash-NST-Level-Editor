namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class BossPapuPapu_AiHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _AiUpdateDeltaTime;
        [FieldAttr(nst: 44)] public float _AttackSpinStartDelay;
        [FieldAttr(nst: 48)] public float _AttackSpinSpeedMultiplier;
        [FieldAttr(nst: 52)] public float _ResumeBossFightDelay;
        [FieldAttr(nst: 56)] public float _IntroMoveSpeedMultiplier;
        [FieldAttr(nst: 60)] public int _AttackSpinPlayerLapCountStart;
        [FieldAttr(nst: 64)] public igHandleMetaField _Float_List = new();
    }
}
