namespace Alchemy
{
    [ObjectAttr(ctr: 496, align: 16)]
    public class CAirArcadeCamera : CConstrainedCamera
    {
        [FieldAttr(ctr: 464)] public float _lookAheadDistance;
        [FieldAttr(ctr: 468)] public float _followDistance;
        [FieldAttr(ctr: 472)] public CCameraScreenSafeArea? _offsetScreenSafeArea;
        [FieldAttr(ctr: 480)] public float _horizontalScreenToWorldScale;
        [FieldAttr(ctr: 484)] public float _verticalScreenToWorldScale;
    }
}
