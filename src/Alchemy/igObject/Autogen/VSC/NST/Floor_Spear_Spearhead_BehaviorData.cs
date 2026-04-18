namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class Floor_Spear_Spearhead_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _CrashDeath = null;
        [FieldAttr(nst: 48)] public string? _String = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data = new();
    }
}
