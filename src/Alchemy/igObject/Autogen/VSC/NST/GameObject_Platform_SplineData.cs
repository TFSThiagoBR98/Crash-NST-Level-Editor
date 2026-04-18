namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 4, metaType: typeof(CVscComponentData))]
    public class GameObject_Platform_SplineData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public EigEaseType _TellEaseType;
        [FieldAttr(nst: 48)] public igHandleMetaField _StartTrigger = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _EndTrigger = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Temple_Platform_Spline = new();
        [FieldAttr(nst: 72)] public float _TellEase;
        [FieldAttr(nst: 76)] public float _TellBobDuration;
        [FieldAttr(nst: 80)] public float _TellDisplacement;
        [FieldAttr(nst: 84)] public float _DurationBeforeMovement;
        [FieldAttr(nst: 88)] public igHandleMetaField _StepReactionSFX = new();
        [FieldAttr(nst: 96)] public string? _StepReactionAnimation = null;
        [FieldAttr(nst: 104)] public igHandleMetaField _StepReactionVFX = new();
    }
}
