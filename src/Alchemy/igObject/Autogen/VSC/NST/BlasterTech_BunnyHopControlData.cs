namespace Alchemy
{
    [ObjectAttr(nst: 136, align: 4, metaType: typeof(CVscComponentData))]
    public class BlasterTech_BunnyHopControlData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _EnterBehaviorGroup = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _EnterThumpBehaviorGroup = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _ExitBehaviorGroup = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _SpeedBoost = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _DustCloudEntityData = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _BunnyEntityData = new();
        [FieldAttr(nst: 88)] public float _AmountToAdd;
        [FieldAttr(nst: 92)] public float _WindUpDuration;
        [FieldAttr(nst: 96)] public float _DashDuration;
        [FieldAttr(nst: 100)] public float _MaxSpeed;
        [FieldAttr(nst: 104)] public int _BunnySpawnCount;
        [FieldAttr(nst: 112)] public string? _GotoDashBehaviorEvent = null;
        [FieldAttr(nst: 120)] public string? _TertiaryFadeOut = null;
        [FieldAttr(nst: 128)] public string? _GotoThumpEndBehaviorEvent = null;
    }
}
