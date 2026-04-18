namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 56, align: 8)]
    public class CClipController : CStackCameraControllerBase
    {
        [FieldAttr(nst: 56, ctr: 52)] public float _distanceDamping = 0.05f;
    }
}
