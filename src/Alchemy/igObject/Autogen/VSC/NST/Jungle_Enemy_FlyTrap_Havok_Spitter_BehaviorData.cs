namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class Jungle_Enemy_FlyTrap_Havok_Spitter_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String_0x28 = null;
        [FieldAttr(nst: 48)] public string? _String_0x30 = null;
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public float _Float_0x3c;
        [FieldAttr(nst: 64)] public igHandleMetaField _Count = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Damage_Data = new();
    }
}
