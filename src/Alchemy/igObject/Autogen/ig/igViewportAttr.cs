namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 4)]
    public class igViewportAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 20)] public int _x;
        [FieldAttr(nst: 28, ctr: 24)] public int _y;
        [FieldAttr(nst: 32, ctr: 28)] public int _w;
        [FieldAttr(nst: 36, ctr: 32)] public int _h;
        [FieldAttr(nst: 40, ctr: 36)] public float _nearZ;
        [FieldAttr(nst: 44, ctr: 40)] public float _farZ = 1.0f;
    }
}
