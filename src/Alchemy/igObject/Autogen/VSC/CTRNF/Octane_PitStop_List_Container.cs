namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_PitStop_List_Container : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Placeable_0x30 = new();
        [FieldAttr(ctr: 56)] public igObject? _Gui_List_Item_List = new();
        [FieldAttr(ctr: 64)] public ESignal _Gui_Input_Signal;
        [FieldAttr(ctr: 68)] public bool _Bool;
        [FieldAttr(ctr: 72)] public igHandleMetaField _Gui_List_Item = new();
        [FieldAttr(ctr: 80)] public EController _Gui_Input_Controller;
    }
}
