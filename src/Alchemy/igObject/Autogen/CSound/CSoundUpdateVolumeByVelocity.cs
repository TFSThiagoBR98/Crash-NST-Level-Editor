namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 56, align: 8)]
    public class CSoundUpdateVolumeByVelocity : CSoundUpdateVelocityBased
    {
        [FieldAttr(nst: 56, ctr: 48)] public float _volumeAtMinVelocity;
        [FieldAttr(nst: 60, ctr: 52)] public float _volumeAtMaxVelocity = 1.0f;
    }
}
