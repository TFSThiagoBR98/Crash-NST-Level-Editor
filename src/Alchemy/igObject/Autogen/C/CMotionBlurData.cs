namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 4)]
    public class CMotionBlurData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _cameraBlurStrength = 1.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _exposureTime = 0.34999999f;
    }
}
