namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 72, align: 8)]
    public class CAudioGraphDriverModeSurfaceReverse : CAudioGraphDriverMode
    {
        [FieldAttr(nst: 56, ctr: 52)] public float _noSpeedGraphInput;
        [FieldAttr(nst: 60, ctr: 56)] public float _maxSpeedGraphInput = 0.5f;
        [FieldAttr(ctr: 60)] public float _slowedPitchModifier;
        [FieldAttr(ctr: 64)] public float _slowedPitchFade;
    }
}
