namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class Medieval_Enemy_Knight_SwordCollision_ComponentData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public bool _Bool_0x38;
        [FieldAttr(nst: 57)] public bool _Bool_0x39;
        [FieldAttr(nst: 58)] public bool _Bool_0x3a;
        [FieldAttr(nst: 59)] public bool _Bool_0x3b;
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public string? _String_0x48 = null;
    }
}
