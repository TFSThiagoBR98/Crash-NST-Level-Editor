namespace Alchemy
{
    [ObjectAttr(ctr: 280, align: 8)]
    public class CGuiBehaviorOctaneCreditsLine : CGuiBehavior
    {
        [FieldAttr(ctr: 144, refCount: false)] public igGuiAnimationTag? _emptyAnim;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiAnimationTag? _headerAnim;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiAnimationTag? _subHeaderAnim;
        [FieldAttr(ctr: 168, refCount: false)] public igGuiAnimationTag? _imageAnim;
        [FieldAttr(ctr: 176, refCount: false)] public igGuiAnimationTag? _singleNameAnim;
        [FieldAttr(ctr: 184, refCount: false)] public igGuiAnimationTag? _twoNamesAnim;
        [FieldAttr(ctr: 192, refCount: false)] public igGuiAnimationTag? _threeNamesAnim;
        [FieldAttr(ctr: 200, refCount: false)] public igGuiPlaceable? _headerTextPlace;
        [FieldAttr(ctr: 208, refCount: false)] public igGuiPlaceable? _subHeaderTextPlace;
        [FieldAttr(ctr: 216, refCount: false)] public igGuiPlaceable? _imagePlace;
        [FieldAttr(ctr: 224, refCount: false)] public igGuiPlaceable? _leftNameText;
        [FieldAttr(ctr: 232, refCount: false)] public igGuiPlaceable? _leftTitleText;
        [FieldAttr(ctr: 240, refCount: false)] public igGuiPlaceable? _centerNameText;
        [FieldAttr(ctr: 248, refCount: false)] public igGuiPlaceable? _centerTitleText;
        [FieldAttr(ctr: 256, refCount: false)] public igGuiPlaceable? _rightNameText;
        [FieldAttr(ctr: 264, refCount: false)] public igGuiPlaceable? _rightTitleText;
        [FieldAttr(ctr: 272)] public CCreditsLine? _creditsLine;
    }
}
