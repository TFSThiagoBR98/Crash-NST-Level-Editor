namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 16, align: 4)]
    public class igVscAccessor : igVscPlaceable
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _isHandle;
        [FieldAttr(nst: 17, ctr: 13)] public bool _isDelegatorTarget;
    }
}
