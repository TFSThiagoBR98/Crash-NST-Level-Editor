namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Racer_HUD_Speedometer : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igObject? _InternalStore_updateNodeUpdater_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Placeable = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 64)] public float _Float_0x40;
        [FieldAttr(ctr: 68)] public EOctaneBoostBarType _E_Octane_Boost_Bar_Type;
        [FieldAttr(ctr: 72)] public float _Float_0x48;
        [FieldAttr(ctr: 76)] public float _Float_0x4c;
        [FieldAttr(ctr: 80)] public float _Float_0x50;
        [FieldAttr(ctr: 84)] public float _Float_0x54;
        [FieldAttr(ctr: 88)] public float _Float_0x58;
        [FieldAttr(ctr: 96)] public igObject? _InternalStore_updateNodeUpdater_0x60 = new();
        [FieldAttr(ctr: 104)] public float _Float_0x68;
        [FieldAttr(ctr: 108)] public float _Float_0x6c;
        [FieldAttr(ctr: 112)] public bool _Bool_0x70;
        [FieldAttr(ctr: 116)] public float _Float_0x74;
        [FieldAttr(ctr: 120)] public float _Float_0x78;
        [FieldAttr(ctr: 124)] public bool _Bool_0x7c;
    }
}
