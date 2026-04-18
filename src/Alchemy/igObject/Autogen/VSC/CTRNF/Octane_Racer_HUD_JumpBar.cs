namespace Alchemy
{
    [ObjectAttr(ctr: 120, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Racer_HUD_JumpBar : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igObject? _InternalStore_updateNodeUpdater_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 64)] public string? _String = null;
        [FieldAttr(ctr: 72)] public igVec4ucMetaField _Color = new();
        [FieldAttr(ctr: 76)] public float _Float_0x4c;
        [FieldAttr(ctr: 80)] public float _Float_0x50;
        [FieldAttr(ctr: 88)] public igObject? _InternalStore__timer = new();
        [FieldAttr(ctr: 96)] public igObject? _InternalStore_updateNodeUpdater_0x60 = new();
        [FieldAttr(ctr: 104)] public float _Float_0x68;
        [FieldAttr(ctr: 108)] public float _Float_0x6c;
        [FieldAttr(ctr: 112)] public float _Float_0x70;
        [FieldAttr(ctr: 116)] public EOctaneBoostBarType _E_Octane_Boost_Bar_Type;
    }
}
