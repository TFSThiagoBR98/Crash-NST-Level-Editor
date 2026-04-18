namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class Egypt_Hazard_FloodWater_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float;
        [FieldAttr(nst: 44)] public bool _Bool;
        [FieldAttr(nst: 48)] public string? _CrashDeath = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _Sound_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Sound_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Entity_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Entity_0x58 = new();
    }
}
