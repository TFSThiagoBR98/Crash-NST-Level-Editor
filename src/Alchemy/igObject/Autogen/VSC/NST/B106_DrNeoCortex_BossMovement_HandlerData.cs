namespace Alchemy
{
    [ObjectAttr(nst: 144, align: 4, metaType: typeof(CVscComponentData))]
    public class B106_DrNeoCortex_BossMovement_HandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public EigEaseType _EaseType;
        [FieldAttr(nst: 44)] public EigEaseType _IntroMoveEaseType;
        [FieldAttr(nst: 48)] public igHandleMetaField _IntroSplineScreenLeft = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _IntroSplineMoverScreenLeft = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _IntroSplineScreenRight = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _IntroSplineMoverScreenRight = new();
        [FieldAttr(nst: 80)] public float _Speed;
        [FieldAttr(nst: 84)] public float _EaseRatioIn;
        [FieldAttr(nst: 88)] public float _EaseRatioOut;
        [FieldAttr(nst: 92)] public float _IntroPlayerRelativeXAxisRange;
        [FieldAttr(nst: 96)] public float _IntroMoveToTauntTime;
        [FieldAttr(nst: 100)] public float _IntroMoveEaseRatioIn;
        [FieldAttr(nst: 104)] public float _IntroMoveEaseRatioOut;
        [FieldAttr(nst: 108)] public float _IntroTauntTime;
        [FieldAttr(nst: 112)] public float _IntroMoveToEndTime;
        [FieldAttr(nst: 120)] public igHandleMetaField _IntroMoveToTauntSplineMarkerScreenLeft = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _IntroMoveToTauntSplineMarkerScreenRight = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _MoveToWaypointList = new();
    }
}
