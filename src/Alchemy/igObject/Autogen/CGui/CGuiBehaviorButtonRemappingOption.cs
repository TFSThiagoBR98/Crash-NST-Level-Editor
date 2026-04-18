namespace Alchemy
{
    [ObjectAttr(nst: 192, align: 8)]
    public class CGuiBehaviorButtonRemappingOption : CGuiBehavior
    {
        [FieldAttr(nst: 144, refCount: false)] public igGuiPlaceable? _textPlaceableLabel;
        [FieldAttr(nst: 152, refCount: false)] public igGuiPlaceable? _textPlaceablePrimaryMapping;
        [FieldAttr(nst: 160, refCount: false)] public igGuiPlaceable? _textPlaceableSecondaryMapping;
        [FieldAttr(nst: 168, refCount: false)] public igGuiAnimationTag? _mappingSelectAnimation;
        [FieldAttr(nst: 176, refCount: false)] public igGuiAnimationTag? _mappingDeselectAnimation;
        [FieldAttr(nst: 184)] public EXBUTTON _xButtonMapping = EXBUTTON.MAX;
        [FieldAttr(nst: 188)] public int _activeMappingIndex;
    }
}
