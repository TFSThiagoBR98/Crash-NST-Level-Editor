namespace Alchemy
{
    [ObjectAttr(nst: 144, align: 8)]
    public class COrbitComponentData : CEntityComponentData
    {
        public enum EOrbitComponentDistanceType
        {
            PingPong = 0,
            UseMinDistance = 1,
            UseMaxDistance = 2,
        }

        public enum EOrbitComponentOrientationType
        {
            eOCOT_DoNotOrient = 0,
            eOCOT_Spin = 1,
            eOCOT_FaceOrbitAroundEntity = 2,
            eOCOT_FaceDirectionOfOrbitAroundEntity = 3,
            eOCOT_FaceDirectionOfOrbit = 4,
        }

        [FieldAttr(nst: 24)] public bool AlwaysSetupOnStart;
        [FieldAttr(nst: 25)] public bool AuthorityOnly;
        [FieldAttr(nst: 32)] public igHandleMetaField OrbitAroundEntity = new();
        [FieldAttr(nst: 40)] public bool DoOrbitAroundParent;
        [FieldAttr(nst: 48)] public CBoltPoint? OrbitBoltPoint;
        [FieldAttr(nst: 56)] public Vector3? OrbitAroundAxis;
        [FieldAttr(nst: 64)] public bool LocalAxis;
        [FieldAttr(nst: 65)] public bool UseInitialAngles;
        [FieldAttr(nst: 66)] public bool UseInitialPosition;
        [FieldAttr(nst: 72)] public Vector3? InitialAngleOffset;
        [FieldAttr(nst: 80)] public EOrbitComponentDistanceType DistanceType;
        [FieldAttr(nst: 88)] public RangedFloat? Distance;
        [FieldAttr(nst: 96)] public float Period = -1.0f;
        [FieldAttr(nst: 100)] public float ExpandTime = -1.0f;
        [FieldAttr(nst: 104)] public float MaxWobble = -1.0f;
        [FieldAttr(nst: 108)] public float WobbleTime = -1.0f;
        [FieldAttr(nst: 112)] public bool OrbitOnStart;
        [FieldAttr(nst: 116)] public float TransitionTime = -1.0f;
        [FieldAttr(nst: 120)] public EOrbitComponentOrientationType OrientationType;
        [FieldAttr(nst: 128)] public Vector3? SpinAxis;
        [FieldAttr(nst: 136)] public float SpinPeriod = 1.0f;
    }
}
