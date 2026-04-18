namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class CAudioGraphDriverModeSurfaceStationary : CAudioGraphDriverModeTargetBased
    {
        [FieldAttr(nst: 72, ctr: 64)] public float _graphInput;
        [FieldAttr(nst: 76, ctr: 68)] public float _noVelocityThreshold = 5.0f;
    }
}
