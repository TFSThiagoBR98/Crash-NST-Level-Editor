namespace Alchemy
{
    [ObjectAttr(ctr: 488, align: 8)]
    public class CGuiBehaviorPlayerCountSelector : CGuiBehaviorBaseSettingSelector
    {
        [FieldAttr(ctr: 448, refCount: false)] public igGuiPlaceable? _placeable;
        [FieldAttr(ctr: 456)] public int _maxPlayerCount;
        [FieldAttr(ctr: 464, refCount: false)] public igGuiAnimationTag? _animCycleNextFailed;
        [FieldAttr(ctr: 472, refCount: false)] public igGuiAnimationTag? _animCyclePreviousFailed;
        [FieldAttr(ctr: 480)] public igHandleMetaField _dialogBox = new();
    }
}
