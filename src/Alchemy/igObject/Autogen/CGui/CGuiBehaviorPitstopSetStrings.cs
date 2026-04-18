namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CGuiBehaviorPitstopSetStrings : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _titleTextPlace;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _buttonTextPlace;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _bodyTextPlace;
    }
}
