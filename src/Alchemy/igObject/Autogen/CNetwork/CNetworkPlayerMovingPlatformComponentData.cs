namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CNetworkPlayerMovingPlatformComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public float _smoothing = 0.15f;
        [FieldAttr(nst: 28, ctr: 20)] public float _smoothingFalloffTime = 0.25f;
        [FieldAttr(nst: 32, ctr: 24)] public float _maxSmoothingDistance = 500.0f;
    }
}
