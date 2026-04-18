namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 88, align: 8)]
    public class CDetectCeilingHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80, ctr: 64)] public float _traceDistanceAccurate = 171.0f;
        [FieldAttr(nst: 84, ctr: 68)] public float _traceDistanceLoose = 110.0f;
        [FieldAttr(nst: 88, ctr: 72)] public float _sphereRadius = 25.0f;
        [FieldAttr(nst: 96, ctr: 80)] public CCollisionMaterialHandleList? _excludeCollisionMaterialList;
    }
}
