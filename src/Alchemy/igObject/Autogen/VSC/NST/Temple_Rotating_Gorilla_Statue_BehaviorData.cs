namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class Temple_Rotating_Gorilla_Statue_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Hazard_Vfx = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Bolt_Point_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Hazard_Sfx = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Warning_Sfx = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Bolt_Point_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Warning_Vfx = new();
        [FieldAttr(nst: 88)] public float _Float;
        [FieldAttr(nst: 92)] public bool _Bool_0x5c;
        [FieldAttr(nst: 93)] public bool _Bool_0x5d;
        [FieldAttr(nst: 94)] public bool _Bool_0x5e;
        [FieldAttr(nst: 96)] public igHandleMetaField _Entity_Data = new();
    }
}
