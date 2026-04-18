namespace Alchemy
{
    [ObjectAttr(ctr: 176, align: 8)]
    public class CGuiBehaviorAdhocJoinButton : CGuiBehavior
    {
        [FieldAttr(ctr: 144, refCount: false)] public igGuiPlaceable? _textDescription;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiAnimationTag? _gainFocusAnimation;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiAnimationTag? _loseFocusAnimation;
        [FieldAttr(ctr: 168)] public int _networkIndex;
    }
}
