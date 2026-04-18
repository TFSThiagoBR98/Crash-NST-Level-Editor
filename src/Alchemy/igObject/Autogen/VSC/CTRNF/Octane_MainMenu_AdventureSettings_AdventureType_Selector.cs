namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_MainMenu_AdventureSettings_AdventureType_Selector : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _Gui_Placeable_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Gui_Placeable_0x30 = new();
        [FieldAttr(ctr: 56)] public EOctaneAdventureType _E_Octane_Adventure_Type_0x38;
        [FieldAttr(ctr: 60)] public EOctaneAdventureType _E_Octane_Adventure_Type_0x3c;
    }
}
