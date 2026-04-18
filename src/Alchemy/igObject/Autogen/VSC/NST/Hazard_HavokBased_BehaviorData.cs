namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_HavokBased_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _Bool_0x28;
        [FieldAttr(nst: 41)] public bool _BouncePlayerUp;
        [FieldAttr(nst: 48)] public string? _String = null;
        [FieldAttr(nst: 56)] public string? _CrashDeath = null;
        [FieldAttr(nst: 64)] public bool _Bool_0x40;
        [FieldAttr(nst: 68)] public float _AttackDelay;
        [FieldAttr(nst: 72)] public float _Float;
        [FieldAttr(nst: 80)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Game_Float_Variable = new();
    }
}
