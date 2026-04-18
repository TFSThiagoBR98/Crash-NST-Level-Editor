namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Customization_Ready_Button : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public EOctaneRaceModes _E_Octane_Race_Modes;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Localized_String_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Localized_String_0x38 = new();
    }
}
