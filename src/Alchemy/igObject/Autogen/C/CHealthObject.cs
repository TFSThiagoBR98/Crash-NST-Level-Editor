namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CHealthObject : igObject
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public CPhysicalEntity? _entity;
        [FieldAttr(nst: 24, ctr: 24)] public int _healthDelta;
    }
}
