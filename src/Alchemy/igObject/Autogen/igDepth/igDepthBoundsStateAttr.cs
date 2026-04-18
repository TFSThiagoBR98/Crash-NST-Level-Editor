namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 4)]
    public class igDepthBoundsStateAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 17)] public bool _enabled;
        [FieldAttr(nst: 28, ctr: 20)] public float _minZ;
        [FieldAttr(nst: 32, ctr: 24)] public float _maxZ = 1.0f;
    }
}
