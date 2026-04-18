namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 4)]
    public class CGlobalRenderData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _AOMaxObscuranceDistance = 30.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _AOConvexThreshold = 3.0f;
        [FieldAttr(nst: 24, ctr: 20)] public float _AOOccludedSampleScale = 15.0f;
        [FieldAttr(nst: 28, ctr: 24)] public float _AOTotalOcclusionScale = 1.75f;
    }
}
