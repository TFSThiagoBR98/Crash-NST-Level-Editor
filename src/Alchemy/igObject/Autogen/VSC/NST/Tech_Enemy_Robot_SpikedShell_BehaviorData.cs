namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class Tech_Enemy_Robot_SpikedShell_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float_0x28;
        [FieldAttr(nst: 44)] public float _Float_0x2c;
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 56)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0x40 = new();
        [FieldAttr(nst: 72)] public bool _Bool_0x48;
        [FieldAttr(nst: 73)] public bool _Bool_0x49;
    }
}
