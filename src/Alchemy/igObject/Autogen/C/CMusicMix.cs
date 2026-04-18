namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 4)]
    public class CMusicMix : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float[] _trackValues = new float[5];
    }
}
