namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 8)]
    public class CRigidAnimCtrl : igTimeTransform2
    {
        [FieldAttr(ctr: 32)] public string? mAnimName;
        [FieldAttr(ctr: 40)] public float mAnimPauseStart;
        [FieldAttr(ctr: 44)] public float mAnimPauseEnd;
        [FieldAttr(ctr: 48)] public float mAnimPauseSpeed;
        [FieldAttr(ctr: 56)] public igVscDelegateMetaField mAnimCycle = new();
        [FieldAttr(ctr: 72)] public igVscDelegateMetaField mAnimComplete = new();
        [FieldAttr(ctr: 88)] public uint mAnimPlaybackId;
        [FieldAttr(ctr: 92)] public ERigidAnimCtrlState mAnimState;
    }
}
