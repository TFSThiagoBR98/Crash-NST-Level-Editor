namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiBehaviorOctaneGhostSelectItemCategory : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _textPlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _countPlaceable;
    }
}
