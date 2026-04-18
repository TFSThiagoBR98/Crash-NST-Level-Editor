namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Help_Hints_Menu_HintsList : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public EController _Gui_Input_Controller;
        [FieldAttr(ctr: 48)] public igObject? _Gui_List_Item_List = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Gui_List_Item = new();
        [FieldAttr(ctr: 64)] public ESignal _Gui_Input_Signal;
    }
}
