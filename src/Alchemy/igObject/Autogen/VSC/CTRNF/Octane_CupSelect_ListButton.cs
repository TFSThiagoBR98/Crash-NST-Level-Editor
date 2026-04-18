namespace Alchemy
{
    [ObjectAttr(ctr: 160, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_CupSelect_ListButton : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public string? _String = null;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(ctr: 56)] public bool _Bool;
        [FieldAttr(ctr: 64)] public igHandleMetaField _Gui_Animation_Tag_0x40 = new();
        [FieldAttr(ctr: 72)] public EOctaneRaceModes _E_Octane_Race_Modes;
        [FieldAttr(ctr: 80)] public igObject? _InternalStore__timer = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _Gui_Placeable_0x58 = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _Gui_Animation_Tag_0x60 = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _Gui_Placeable_0x68 = new();
        [FieldAttr(ctr: 112)] public igObject? _InternalStore_updateNodeUpdater_0x70 = new();
        [FieldAttr(ctr: 120)] public igObject? _InternalStore_updateNodeUpdater_0x78 = new();
        [FieldAttr(ctr: 128)] public ESignal _Gui_Input_Signal;
        [FieldAttr(ctr: 132)] public EController _Gui_Input_Controller;
        [FieldAttr(ctr: 136)] public igObject? _Gui_List_Item_List = new();
        [FieldAttr(ctr: 144)] public igHandleMetaField _Gui_List_Item = new();
        [FieldAttr(ctr: 152)] public float _Float_0x98;
        [FieldAttr(ctr: 156)] public float _Float_0x9c;
    }
}
