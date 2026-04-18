namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_CameraPortalFocusData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public EigEaseType _Ease_Type;
        [FieldAttr(nst: 44)] public EigEaseMode _Ease_Mode;
        [FieldAttr(nst: 48)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 56)] public igVec3fMetaField _Vector3 = new();
        [FieldAttr(nst: 68)] public bool _Bool;
        [FieldAttr(nst: 72)] public igHandleMetaField _Camera_Base = new();
    }
}
