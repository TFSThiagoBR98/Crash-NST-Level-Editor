namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 64, align: 8)]
    public class igMetaFunction : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _functionName = null;
        [FieldAttr(nst: 24, ctr: 24)] public uint _functionPointer;
        [FieldAttr(nst: 56, ctr: 40)] public igObject? _attributes;
        [FieldAttr(nst: 64, ctr: 48)] public igObject? _parameters;
        [FieldAttr(nst: 72, ctr: 56)] public uint _properties;
    }
}
