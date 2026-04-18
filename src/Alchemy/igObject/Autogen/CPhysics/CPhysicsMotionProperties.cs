namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class CPhysicsMotionProperties : igNamedObject
    {
        public enum EStabilizationType
        {
            eST_Off = 0,
            eST_Low = 1,
            eST_Medium = 2,
            eST_High = 3,
            eST_Aggressive = 4,
        }

        [FieldAttr(nst: 24, ctr: 24)] public float _gravityFactor = 1.0f;
        [FieldAttr(nst: 28, ctr: 28)] public float _timeFactor = 1.0f;
        [FieldAttr(nst: 32, ctr: 32)] public float _maxLinearSpeed = 200.0f;
        [FieldAttr(nst: 36, ctr: 36)] public float _maxAngularSpeed = 100.0f;
        [FieldAttr(nst: 40, ctr: 40)] public float _linearDamping;
        [FieldAttr(nst: 44, ctr: 44)] public float _angularDamping;
        [FieldAttr(nst: 48, ctr: 48)] public EStabilizationType _stabilizationType;
        [FieldAttr(ctr: 52)] public bool _useGravityModifier;
        [FieldAttr(nst: 52, ctr: 53)] public bool _isMutable;
        [FieldAttr(nst: 53, ctr: 54)] public bool _finalizeCalled;
        [FieldAttr(nst: 54, ctr: 56)] public uint _dynamicMotionPropertiesId;
        [FieldAttr(nst: 56, ctr: 58)] public uint _keyframedMotionPropertiesId;
    }
}
