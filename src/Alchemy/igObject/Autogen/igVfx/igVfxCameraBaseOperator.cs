namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxCameraBaseOperator : igVfxOperator
    {
        [FieldAttr(nst: 24, ctr: 16)] public float _startDistance = 500.0f;
        [FieldAttr(nst: 28, ctr: 20)] public float _endDistance;
    }
}
