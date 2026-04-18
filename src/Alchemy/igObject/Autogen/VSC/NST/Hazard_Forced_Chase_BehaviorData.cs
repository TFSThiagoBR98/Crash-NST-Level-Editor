namespace Alchemy
{
    [ObjectAttr(nst: 136, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_Forced_Chase_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _DestroyAtEnd;
        [FieldAttr(nst: 41)] public bool _HurtOnIdle;
        [FieldAttr(nst: 48)] public igHandleMetaField _OptionalTrigger = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _SplineSnapAttachBehavior = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _SplineRotationMover = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _SplineVelocityMover = new();
        [FieldAttr(nst: 80)] public string? _IdleStart = null;
        [FieldAttr(nst: 88)] public string? _IdleEnd = null;
        [FieldAttr(nst: 96)] public string? _Chase = null;
        [FieldAttr(nst: 104)] public float _Float_0x68;
        [FieldAttr(nst: 108)] public float _Float_0x6c;
        [FieldAttr(nst: 112)] public float _Float_0x70;
        [FieldAttr(nst: 116)] public bool _Bool;
        [FieldAttr(nst: 120)] public float _Float_0x78;
        [FieldAttr(nst: 128)] public igHandleMetaField _Entity = new();
    }
}
