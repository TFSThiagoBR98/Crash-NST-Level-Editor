namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class CAmbientOcclusionRenderData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _radius = 50.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _scale = 1.39999998f;
        [FieldAttr(nst: 24, ctr: 20)] public float _bias = 1.0f;
    }
}
