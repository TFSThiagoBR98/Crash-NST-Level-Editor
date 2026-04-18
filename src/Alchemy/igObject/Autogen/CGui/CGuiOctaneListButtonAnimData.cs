namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CGuiOctaneListButtonAnimData : igObject
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiAnimationTag? _pressedAnimation;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiAnimationTag? _focusAnimation;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _defocusAnimation;
        [FieldAttr(ctr: 40)] public igHandleMetaField _levelAmbienceSFX = new();
    }
}
