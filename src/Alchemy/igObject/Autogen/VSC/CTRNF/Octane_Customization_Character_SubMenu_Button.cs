namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Customization_Character_SubMenu_Button : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public ECustomizationType _Gui_List_Item_Populator_Customization_Grid_E_Customization_Type;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Localized_String = new();
        [FieldAttr(ctr: 56)] public bool _Bool;
    }
}
