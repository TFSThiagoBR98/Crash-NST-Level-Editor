namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Lab_Welder_FlameProjectile_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_Data = new();
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 56)] public igHandleMetaField _Bolt_Point_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 72)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(nst: 84)] public float _Float_0x54;
        [FieldAttr(nst: 88)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Bolt_Point_0x60 = new();
    }
}
