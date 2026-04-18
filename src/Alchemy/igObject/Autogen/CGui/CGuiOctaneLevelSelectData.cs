namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CGuiOctaneLevelSelectData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _levelName;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiAnimationTag? _pressedAnimation;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _focusAnimation;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _defocusAnimation;
        [FieldAttr(ctr: 48)] public igHandleMetaField _levelAmbienceSFX = new();
    }
}
