namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class CAlphaClipAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 17)] public bool _enable;
        [FieldAttr(nst: 28, ctr: 20)] public float _threshold = 0.5f;
    }
}
