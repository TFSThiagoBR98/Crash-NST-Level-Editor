namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class Plane_Enemy_BiPlane_Large_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String = null;
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 56)] public igHandleMetaField _Debug_Update_Channel = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Bolt_Point_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Entity_0x50 = new();
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 92)] public float _Float_0x5c;
        [FieldAttr(nst: 96)] public float _Float_0x60;
        [FieldAttr(nst: 104)] public igHandleMetaField _Bolt_Point_0x68 = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Entity_0x70 = new();
        [FieldAttr(nst: 120)] public float _Float_0x78;
        [FieldAttr(nst: 124)] public float _Float_0x7c;
    }
}
