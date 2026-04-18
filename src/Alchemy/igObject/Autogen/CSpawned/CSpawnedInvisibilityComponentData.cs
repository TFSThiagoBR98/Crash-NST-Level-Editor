namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CSpawnedInvisibilityComponentData : CSpawnedPowerUpComponentData
    {
        [FieldAttr(ctr: 20)] public float _duration;
        [FieldAttr(ctr: 24)] public float _delayStart;
    }
}
