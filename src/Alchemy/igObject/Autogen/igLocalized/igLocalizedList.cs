namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igLocalizedList : igStringRefList
    {
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _object = new();
        [FieldAttr(nst: 48, ctr: 48)] public igObject? _field;
    }
}
