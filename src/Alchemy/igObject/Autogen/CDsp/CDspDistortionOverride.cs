namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CDspDistortionOverride : CDspOverride
    {
        [FieldAttr(nst: 32)] public float _level = 0.5f;
    }
}
