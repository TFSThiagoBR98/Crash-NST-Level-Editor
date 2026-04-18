namespace Alchemy
{
    [ObjectAttr(nst: 432, ctr: 464, align: 16)]
    public class CConstrainedCamera : CCamera
    {
        [FieldAttr(nst: 416, ctr: 448)] public float _targetRadiusMin = 600.0f;
        [FieldAttr(nst: 420, ctr: 452)] public float _targetRadiusMax = 800.0f;
        [FieldAttr(nst: 424, ctr: 456)] public CCameraScreenSafeArea? _screenSafeArea;
    }
}
