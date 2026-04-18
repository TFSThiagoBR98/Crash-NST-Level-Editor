namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CPrioritizedUpgrade : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _upgrade = new();
        [FieldAttr(nst: 24, ctr: 24)] public int _priority;
    }
}
