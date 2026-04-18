namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 4)]
    public class CCameraClipSettings : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _nearPlane = 32.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _farPlane = 2.0f;
    }
}
