namespace Alchemy
{
    [ObjectAttr(ctr: 192, align: 8)]
    public class CGuiBehaviorHUBMinimapPlayer : CGuiBehaviorHUBMinimapElement
    {
        [FieldAttr(ctr: 144)] public igHandleMetaField _topLevel = new();
        [FieldAttr(ctr: 152)] public igVec2fMetaField _topLeft = new();
        [FieldAttr(ctr: 160)] public igVec2fMetaField _bottomRight = new();
        [FieldAttr(ctr: 168)] public igHandleMetaField _racer = new();
        [FieldAttr(ctr: 176)] public igHandleMetaField _iconPositionEntity = new();
        [FieldAttr(ctr: 184)] public CSetHUBMinimapAnimationsEvent? _animStartEvent;
    }
}
