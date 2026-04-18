namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class CrashBandicoot_JumpFlipData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _JumpStateGroup_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _JumpStateGroup_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Behavior_State_Group = new();
        [FieldAttr(nst: 64)] public float _Float_0x40;
        [FieldAttr(nst: 68)] public float _Float_0x44;
    }
}
