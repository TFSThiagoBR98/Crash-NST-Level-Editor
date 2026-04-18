namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class A224_Frozen_Frenzy_Blade_SFXData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Sound_0x20 = new();
        [FieldAttr(ctr: 40)] public float _Float;
        [FieldAttr(ctr: 44)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Sound_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Sound_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Rumble_Data = new();
    }
}
