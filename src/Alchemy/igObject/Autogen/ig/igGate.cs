namespace Alchemy
{
    [ObjectAttr(nst: 24, align: 4)]
    public class igGate : igObject
    {
        [FieldAttr(nst: 16)] public int _count;
        [FieldAttr(nst: 20)] public bool _open = true;
    }
}
