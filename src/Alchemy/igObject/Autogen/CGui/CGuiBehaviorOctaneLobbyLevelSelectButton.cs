namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CGuiBehaviorOctaneLobbyLevelSelectButton : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _mapNamePlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _mapIconPlaceable;
        [FieldAttr(ctr: 32)] public igHandleMetaField _menuToOpen = new();
    }
}
