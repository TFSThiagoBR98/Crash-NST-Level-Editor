namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Common_Enemy_RotateToPlayer_BehaviorData : CVscComponentData
    {
        public enum ERotationAxis
        {
            XAxis = 0,
            YAxis = 1,
            ZAxis = 2,
        }

        [FieldAttr(nst: 40)] public ERotationAxis _RotationAxis;
        [FieldAttr(nst: 44)] public float _RotateTime;
        [FieldAttr(nst: 48)] public float _ClampRotation;
        [FieldAttr(nst: 52)] public float _RotationOffset;
        [FieldAttr(nst: 56)] public bool _Bool_0x38;
        [FieldAttr(nst: 57)] public bool _Bool_0x39;
        [FieldAttr(nst: 58)] public bool _Bool_0x3a;
        [FieldAttr(nst: 59)] public bool _Bool_0x3b;
    }
}
