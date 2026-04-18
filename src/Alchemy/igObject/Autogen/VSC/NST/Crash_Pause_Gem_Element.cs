namespace Alchemy
{
    [ObjectAttr(nst: 152, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Crash_Pause_Gem_Element : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public ECrashGame _E_Crash_Game_0x28;
        [FieldAttr(nst: 48)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 56)] public EZoneCollectibleType _E_Zone_Collectible_Type;
        [FieldAttr(nst: 64)] public igHandleMetaField _Zone_Info_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Zone_Info_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Zone_Info_0x50 = new();
        [FieldAttr(nst: 88)] public igObject? _InternalStore_updateNodeUpdater_0x58 = new();
        [FieldAttr(nst: 96)] public igObject? _InternalStore__gate_0x60 = new();
        [FieldAttr(nst: 104)] public bool _Bool;
        [FieldAttr(nst: 112)] public igObject? _InternalStore_listener = new();
        [FieldAttr(nst: 120)] public igObject? _InternalStore_updateNodeUpdater_0x78 = new();
        [FieldAttr(nst: 128)] public igObject? _InternalStore__gate_0x80 = new();
        [FieldAttr(nst: 136)] public ECrashGame _E_Crash_Game_0x88;
        [FieldAttr(nst: 144)] public igHandleMetaField _Zone_Info_0x90 = new();
    }
}
