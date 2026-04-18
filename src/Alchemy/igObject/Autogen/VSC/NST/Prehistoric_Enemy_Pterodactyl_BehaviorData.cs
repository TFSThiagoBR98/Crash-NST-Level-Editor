namespace Alchemy
{
    [ObjectAttr(nst: 144, align: 4, metaType: typeof(CVscComponentData))]
    public class Prehistoric_Enemy_Pterodactyl_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _Spawn_0x28 = null;
        [FieldAttr(nst: 48)] public string? _Spawn_0x30 = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _Zone_Info = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 72)] public bool _Bool;
        [FieldAttr(nst: 80)] public string? _Spawn_0x50 = null;
        [FieldAttr(nst: 88)] public string? _String_0x58 = null;
        [FieldAttr(nst: 96)] public string? _String_0x60 = null;
        [FieldAttr(nst: 104)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Game_Int_Variable = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Fade_Out_Preset_Data = new();
        [FieldAttr(nst: 128)] public ECrashSecretZones _E_Crash_Secret_Zones;
        [FieldAttr(nst: 136)] public string? _String_0x88 = null;
    }
}
