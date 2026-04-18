namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Look_At_After_DelayData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 56)] public igHandleMetaField _Camera_Base = new();
        [FieldAttr(nst: 64)] public float _Float_0x40;
        [FieldAttr(nst: 68)] public float _Float_0x44;
        [FieldAttr(nst: 72)] public igVec3fMetaField _Vec_3F_0x48 = new();
        [FieldAttr(nst: 84)] public igVec3fMetaField _Vec_3F_0x54 = new();
    }
}
