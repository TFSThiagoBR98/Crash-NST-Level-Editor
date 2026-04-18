namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 4)]
    public class CSpeakerVolumes : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _leftFrontVolume = 1.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _rightFrontVolume = 1.0f;
        [FieldAttr(nst: 24, ctr: 20)] public float _centerVolume;
        [FieldAttr(nst: 28, ctr: 24)] public float _leftBackVolume;
        [FieldAttr(nst: 32, ctr: 28)] public float _rightBackVolume;
        [FieldAttr(nst: 36, ctr: 32)] public float _leftCenterVolume;
        [FieldAttr(nst: 40, ctr: 36)] public float _rightCenterVolume;
        [FieldAttr(nst: 44, ctr: 40)] public float _lowFrequencyVolume;
    }
}
