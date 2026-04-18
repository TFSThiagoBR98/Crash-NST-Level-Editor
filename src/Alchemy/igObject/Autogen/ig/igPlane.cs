namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igPlane : igVolume
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVec3fMetaField _norm = new();
        [FieldAttr(nst: 28, ctr: 24)] public float _offset;
        [FieldAttr(nst: 32, ctr: 28)] public EIG_MATH_SPATIAL_REGION _octant;
    }
}
