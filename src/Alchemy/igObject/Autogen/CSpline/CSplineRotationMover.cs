namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 128, align: 16)]
    public class CSplineRotationMover : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public EMoverBehavior _rotationType;
        [FieldAttr(nst: 20, ctr: 16)] public float _convergeRatio;
        [FieldAttr(nst: 24, ctr: 20)] public bool _convergeCompleted;
        [FieldAttr(nst: 32, ctr: 32)] public igMatrix44fMetaField _transform = new();
        [FieldAttr(nst: 96, ctr: 96)] public igQuaternionfMetaField _startOrientation = new();
        [FieldAttr(nst: 112, ctr: 112)] public igVec3fMetaField _startAngles = new();
    }
}
