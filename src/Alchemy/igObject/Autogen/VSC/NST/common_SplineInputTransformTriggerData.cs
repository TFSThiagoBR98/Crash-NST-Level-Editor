namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_SplineInputTransformTriggerData : CVscComponentData
    {
        public enum ENewEnum8_id_ntdpr081
        {
            Stop = 0,
            StartSpline = 1,
            StartCircular = 2,
        }

        [FieldAttr(nst: 40)] public ENewEnum8_id_ntdpr081 _NewEnum8_id_ntdpr081;
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public bool _Bool_0x38;
        [FieldAttr(nst: 60)] public igVec2fMetaField _Vec_2F = new();
        [FieldAttr(nst: 68)] public float _Float;
        [FieldAttr(nst: 72)] public bool _Bool_0x48;
    }
}
