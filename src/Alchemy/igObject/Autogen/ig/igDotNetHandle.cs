namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 8)]
    public class igDotNetHandle : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _handle = new();
    }
}
