namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class Sewer_TiltPlatformData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float_0x28;
        [FieldAttr(nst: 44)] public float _Float_0x2c;
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Havok_Ball_And_Socket_Constraint_Data = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Havok_Stiff_Spring_Constraint_Data = new();
    }
}
