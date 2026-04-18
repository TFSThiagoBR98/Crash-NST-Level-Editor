namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 72, align: 4)]
    public class igRenderAuxiliaryCullingParameters : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _distanceCulling;
        [FieldAttr(nst: 20, ctr: 16)] public float[] _distanceCullStart = new float[5];
        [FieldAttr(nst: 36, ctr: 36)] public float[] _distanceCullFadeRange = new float[5];
        [FieldAttr(nst: 40, ctr: 56)] public bool _smallObjectCulling;
        [FieldAttr(nst: 44, ctr: 60)] public float _smallObjectDistance;
        [FieldAttr(nst: 48, ctr: 64)] public float _smallObjectSize = 2.0f;
    }
}
