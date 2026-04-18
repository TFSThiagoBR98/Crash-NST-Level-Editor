namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class Octane_Customization_PlayerInfo_InfoBox_ButtonText : igGuiVscBehavior
    {
        [FieldAttr(ctr: 40)] public string? _String = null;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Entity = new();
    }
}
