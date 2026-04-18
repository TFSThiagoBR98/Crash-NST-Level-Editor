namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class CDspSfxReverbOverride : CDspOverride
    {
        [FieldAttr(nst: 32, ctr: 28)] public float _dryLevel;
        [FieldAttr(nst: 36, ctr: 32)] public float _room = -1.0f;
        [FieldAttr(nst: 40, ctr: 36)] public float _roomHf;
        [FieldAttr(nst: 44, ctr: 40)] public float _decayTime = 1.0f;
        [FieldAttr(nst: 48, ctr: 44)] public float _decayHfRatio = 0.5f;
        [FieldAttr(nst: 52, ctr: 48)] public float _reflections = -1.0f;
        [FieldAttr(nst: 56, ctr: 52)] public float _reflectDelay = 0.02f;
        [FieldAttr(nst: 60, ctr: 56)] public float _reverb;
        [FieldAttr(nst: 64, ctr: 60)] public float _reverbDelay = 0.04f;
        [FieldAttr(nst: 68, ctr: 64)] public float _diffusion = 100.0f;
        [FieldAttr(nst: 72, ctr: 68)] public float _density = 100.0f;
        [FieldAttr(nst: 76, ctr: 72)] public float _hfReference = 5000.0f;
        [FieldAttr(nst: 80, ctr: 76)] public float _roomLf;
        [FieldAttr(nst: 84, ctr: 80)] public float _lfReference = 250.0f;
    }
}
