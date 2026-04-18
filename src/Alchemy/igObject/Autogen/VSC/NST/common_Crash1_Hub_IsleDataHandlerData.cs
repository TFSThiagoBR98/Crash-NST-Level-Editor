namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Crash1_Hub_IsleDataHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _CrashHubSplineEntity = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _CameraSplineEntity = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _TransitionPreviousIsleCameraSplineEntity = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _TransitionNextIsleCameraSplineEntity = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _MapSpotList = new();
    }
}
