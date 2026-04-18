namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNGin_C3Mech01_MoveHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public EigEaseType _Ease_Type;
        [FieldAttr(nst: 44)] public float _Float_0x2c;
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 56)] public igHandleMetaField _Waypoint = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Spline_Rotation_Mover = new();
    }
}
