namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4)]
    public class CSplineLinearConvergeAttachBehavior : CSplineAttachBehavior
    {
        [FieldAttr(nst: 24)] public float _convergeRatio = 0.3f;
        [FieldAttr(nst: 28)] public bool _convergeX = true;
        [FieldAttr(nst: 29)] public bool _convergeY = true;
        [FieldAttr(nst: 30)] public bool _convergeZ = true;
        [FieldAttr(nst: 31)] public bool _convergeFromWorldPosition = true;
        [FieldAttr(nst: 32)] public bool _convergeCompleted;
        [FieldAttr(nst: 36)] public igVec3fMetaField _startPositionOrOffset = new();
    }
}
