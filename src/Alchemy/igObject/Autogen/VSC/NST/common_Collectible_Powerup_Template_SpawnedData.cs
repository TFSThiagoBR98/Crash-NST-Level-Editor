namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Collectible_Powerup_Template_SpawnedData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Localized_String_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Localized_String_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 72)] public float _Float;
        [FieldAttr(nst: 80)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Material = new();
        [FieldAttr(nst: 96)] public ECrashGame _E_Crash_Game;
    }
}
