namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class igRefMetaFieldInstance : igMetaFieldInstance
    {
        [FieldAttr(nst: 72, ctr: 64)] public bool _construct;
        [FieldAttr(nst: 73, ctr: 65)] public bool _destruct;
        [FieldAttr(nst: 74, ctr: 66)] public bool _reconstruct;
        [FieldAttr(nst: 75, ctr: 67)] public bool _refCounted = true;
    }
}
