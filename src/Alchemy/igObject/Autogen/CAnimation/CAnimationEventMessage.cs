namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8)]
    public class CAnimationEventMessage : CEntityMessage
    {
        [FieldAttr(nst: 56)] public SAnimationPlaybackInfoMetaField _animationPlaybackInfo = new();
        [FieldAttr(nst: 88)] public string? _animationName = null;
    }
}
