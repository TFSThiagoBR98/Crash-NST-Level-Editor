namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNGin_C2Mech_FaceCrashData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Behavior_State_Group = new();
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 52)] public EigEaseType _Ease_Type;
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public float _Float_0x3c;
    }
}
