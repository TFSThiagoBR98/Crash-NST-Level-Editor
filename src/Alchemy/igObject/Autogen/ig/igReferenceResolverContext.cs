namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igReferenceResolverContext : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igObjectList? _rootObjects;
        [FieldAttr(nst: 24, ctr: 24)] public igMemoryRef<i8> _basePath = new();
        [FieldAttr(nst: 40, ctr: 40)] public igStringObjectHashTable? _data;
    }
}
