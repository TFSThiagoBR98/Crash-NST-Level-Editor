namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CSplineInputTransformController : CBaseInputTransformController
    {
        [FieldAttr(nst: 16, refCount: false)] public CEntity? _splineEntity;
        [FieldAttr(nst: 24)] public bool _reversed;
    }
}
