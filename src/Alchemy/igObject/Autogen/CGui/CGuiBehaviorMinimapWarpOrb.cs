namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 8)]
    public class CGuiBehaviorMinimapWarpOrb : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _orbPlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _targetPlaceable;
        [FieldAttr(ctr: 32)] public igHandleMetaField _topLevel = new();
        [FieldAttr(ctr: 40)] public igVec2fMetaField _topLeft = new();
        [FieldAttr(ctr: 48)] public igVec2fMetaField _bottomRight = new();
        [FieldAttr(ctr: 56)] public ERacingMinimapDirection _minimapDirection;
        [FieldAttr(ctr: 64)] public igHandleMetaField _orbEntity = new();
        [FieldAttr(ctr: 72)] public bool _toRemove;
        [FieldAttr(ctr: 73)] public bool _active;
        [FieldAttr(ctr: 80)] public CGuiEventDespawnPlaceable? _despawnEvent;
    }
}
