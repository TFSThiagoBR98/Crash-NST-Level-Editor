namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_PlaySoundOnContactDuringAnimationData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _ContactSound = new();
        [FieldAttr(nst: 48)] public string? _AnimationState = null;
        [FieldAttr(nst: 56)] public string? _AnimationState2 = null;
    }
}
