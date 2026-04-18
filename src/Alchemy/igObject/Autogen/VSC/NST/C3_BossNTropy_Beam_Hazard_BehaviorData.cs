namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class C3_BossNTropy_Beam_Hazard_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Bolt_Point_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Bolt_Point_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 72)] public float _Float;
    }
}
