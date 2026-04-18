namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CGuiBehaviorSplitScreenDivider : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _horizontalDivider;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _verticalDivider;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _bottomRightBackground;
    }
}
