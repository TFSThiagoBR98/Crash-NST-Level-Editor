namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Gem_Platform_Spline_c : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _LockPlayer;
        [FieldAttr(nst: 48)] public igHandleMetaField _LockedPlayerCamera = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _ExitingCamera = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Spline = new();
        [FieldAttr(nst: 72)] public float _WaitToReverse;
        [FieldAttr(nst: 76)] public float _WaitToMove;
        [FieldAttr(nst: 80)] public igHandleMetaField _CrashRidingPlatform = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _minigame = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _SplineMoverSettings = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Spline_Rotation_Mover = new();
        [FieldAttr(nst: 112)] public bool _Bool_0x70;
        [FieldAttr(nst: 116)] public float _Float_0x74;
        [FieldAttr(nst: 120)] public float _Float_0x78;
        [FieldAttr(nst: 124)] public bool _Bool_0x7c;
    }
}
