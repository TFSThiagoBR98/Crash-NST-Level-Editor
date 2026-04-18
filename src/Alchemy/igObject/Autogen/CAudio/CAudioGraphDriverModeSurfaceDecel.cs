namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class CAudioGraphDriverModeSurfaceDecel : CAudioGraphDriverMode
    {
        [FieldAttr(nst: 56, ctr: 52)] public float _noSpeedGraphInput;
        [FieldAttr(ctr: 56)] public float _slowedPitchModifier;
        [FieldAttr(ctr: 60)] public float _slowedPitchFade;
        [FieldAttr(nst: 60, ctr: 64)] public float _maxSpeedGraphInput;
        [FieldAttr(nst: 64, ctr: 68)] public float _startingSpeed;
    }
}
