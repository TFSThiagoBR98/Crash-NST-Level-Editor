namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CSplineLaneAttachBehavior : CSplineAttachBehavior
    {
        [FieldAttr(nst: 24, ctr: 16, refCount: false)] public CEntity? _entityOnSpline;
        [FieldAttr(nst: 32, ctr: 24)] public float _localXPosition;
    }
}
