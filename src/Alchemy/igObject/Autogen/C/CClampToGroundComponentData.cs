namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CClampToGroundComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public float _aboveOffset = 1000.0f;
        [FieldAttr(nst: 28, ctr: 20)] public float _belowOffset = 1000.0f;
        [FieldAttr(nst: 32, ctr: 24)] public float _zOffset;
        [FieldAttr(nst: 36, ctr: 28)] public bool _runOnce;
        [FieldAttr(ctr: 29)] public bool _followWater;
    }
}
