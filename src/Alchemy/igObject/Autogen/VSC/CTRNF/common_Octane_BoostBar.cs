namespace Alchemy
{
    [ObjectAttr(ctr: 160, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class common_Octane_BoostBar : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public bool _Bool;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 56)] public float _Float_0x38;
        [FieldAttr(ctr: 60)] public float _Float_0x3c;
        [FieldAttr(ctr: 64)] public float _Float_0x40;
        [FieldAttr(ctr: 68)] public igVec4ucMetaField _Color_0x44 = new();
        [FieldAttr(ctr: 72)] public igVec4ucMetaField _Color_0x48 = new();
        [FieldAttr(ctr: 80)] public igObject? _InternalStore_updateNodeUpdater_0x50 = new();
        [FieldAttr(ctr: 88)] public igObject? _InternalStore_updateNodeUpdater_0x58 = new();
        [FieldAttr(ctr: 96)] public igObject? _InternalStore_updateNodeUpdater_0x60 = new();
        [FieldAttr(ctr: 104)] public igObject? _InternalStore_updateNodeUpdater_0x68 = new();
        [FieldAttr(ctr: 112)] public igObject? _InternalStore_updateNodeUpdater_0x70 = new();
        [FieldAttr(ctr: 120)] public igHandleMetaField _Gui_Placeable_0x78 = new();
        [FieldAttr(ctr: 128)] public igHandleMetaField _Vfx_Spawned_Effect = new();
        [FieldAttr(ctr: 136)] public igHandleMetaField _Gui_Placeable_0x88 = new();
        [FieldAttr(ctr: 144)] public igHandleMetaField _Gui_Animation_Tag = new();
        [FieldAttr(ctr: 152)] public float _Float_0x98;
    }
}
