namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class Plane_Enemy_BiPlane_Engine_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public int _Int_0x28;
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect_0x30 = new();
        [FieldAttr(nst: 56)] public int _Int_0x38;
        [FieldAttr(nst: 64)] public igHandleMetaField _Vfx_Effect_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Bolt_Point_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Bolt_Point_0x50 = new();
    }
}
