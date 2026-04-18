namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Progression_Menu_AreaList : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_List_Item = new();
        [FieldAttr(ctr: 48)] public ESignal _Gui_Input_Signal;
        [FieldAttr(ctr: 52)] public EController _Gui_Input_Controller;
        [FieldAttr(ctr: 56)] public igObject? _Gui_List_Item_List = new();
    }
}
