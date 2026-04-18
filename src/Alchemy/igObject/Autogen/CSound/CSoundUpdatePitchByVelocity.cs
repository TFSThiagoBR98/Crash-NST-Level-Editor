namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 56, align: 8)]
    public class CSoundUpdatePitchByVelocity : CSoundUpdateVelocityBased
    {
        [FieldAttr(nst: 56, ctr: 48)] public float _pitchAtMinVelocity;
        [FieldAttr(nst: 60, ctr: 52)] public float _pitchAtMaxVelocity;
    }
}
