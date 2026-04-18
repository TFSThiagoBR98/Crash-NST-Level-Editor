namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CGuiEventRacingMinimapIconSetup : igGuiEvent
    {
        [FieldAttr(ctr: 24)] public ERacingMinimapDirection _racersMinimapDirection;
        [FieldAttr(ctr: 28)] public igVec2fMetaField _topLeft = new();
        [FieldAttr(ctr: 36)] public igVec2fMetaField _bottomRight = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _topLevel = new();
    }
}
