namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CGuiBehaviorLinearMinimapWarpOrb : CGuiBehaviorLinearMinimapIcon
    {
        [FieldAttr(ctr: 56)] public igHandleMetaField _orbEntity = new();
        [FieldAttr(ctr: 64)] public bool _toRemove;
        [FieldAttr(ctr: 65)] public bool _active;
        [FieldAttr(ctr: 72)] public CGuiEventDespawnPlaceable? _despawnEvent;
    }
}
