namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 152, align: 8)]
    public class CDspSfxReverb : CDsp
    {
        [FieldAttr(nst: 48, ctr: 40)] public float _dryLevel;
        [FieldAttr(nst: 52, ctr: 44)] public float _room = -1.0f;
        [FieldAttr(nst: 56, ctr: 48)] public float _roomHf;
        [FieldAttr(nst: 60, ctr: 52)] public float _decayTime = 1.0f;
        [FieldAttr(nst: 64, ctr: 56)] public float _decayHfRatio = 0.5f;
        [FieldAttr(nst: 68, ctr: 60)] public float _reflections = -1.0f;
        [FieldAttr(nst: 72, ctr: 64)] public float _reflectDelay = 0.02f;
        [FieldAttr(nst: 76, ctr: 68)] public float _reverb;
        [FieldAttr(nst: 80, ctr: 72)] public float _reverbDelay = 0.04f;
        [FieldAttr(nst: 84, ctr: 76)] public float _diffusion = 100.0f;
        [FieldAttr(nst: 88, ctr: 80)] public float _density = 100.0f;
        [FieldAttr(nst: 92, ctr: 84)] public float _hfReference = 5000.0f;
        [FieldAttr(nst: 96, ctr: 88)] public float _roomLf;
        [FieldAttr(nst: 100, ctr: 92)] public float _lfReference = 250.0f;
        [FieldAttr(nst: 104, ctr: 96)] public float _dryLevelValue;
        [FieldAttr(nst: 108, ctr: 100)] public float _roomValue;
        [FieldAttr(nst: 112, ctr: 104)] public float _roomHfValue;
        [FieldAttr(nst: 116, ctr: 108)] public float _decayTimeValue;
        [FieldAttr(nst: 120, ctr: 112)] public float _decayHfRatioValue;
        [FieldAttr(nst: 124, ctr: 116)] public float _reflectionsValue;
        [FieldAttr(nst: 128, ctr: 120)] public float _reflectDelayValue;
        [FieldAttr(nst: 132, ctr: 124)] public float _reverbValue;
        [FieldAttr(nst: 136, ctr: 128)] public float _reverbDelayValue;
        [FieldAttr(nst: 140, ctr: 132)] public float _diffusionValue;
        [FieldAttr(nst: 144, ctr: 136)] public float _densityValue;
        [FieldAttr(nst: 148, ctr: 140)] public float _hfReferenceValue;
        [FieldAttr(nst: 152, ctr: 144)] public float _roomLfValue;
        [FieldAttr(nst: 156, ctr: 148)] public float _lfReferenceValue;
    }
}
