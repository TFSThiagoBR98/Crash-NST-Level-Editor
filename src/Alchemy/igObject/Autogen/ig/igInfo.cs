namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igInfo : igReferenceResolver
    {
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igDirectory? _directory;
        [FieldAttr(nst: 32, ctr: 32)] public bool _resolveState = true;
    }
}
