namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CDspOverrideSet : igObjectList<CDspOverride>
    {
        [FieldAttr(nst: 40, ctr: 40)] public float _fadeInTime = 2.0f;
    }
}
