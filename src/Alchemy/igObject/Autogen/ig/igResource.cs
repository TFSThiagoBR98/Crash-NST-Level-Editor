namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 56, align: 8)]
    public class igResource : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _useMemoryPoolAssignmentsState = true;
        [FieldAttr(nst: 24, ctr: 16)] public igDirectoryList? _directoryList;
        [FieldAttr(nst: 32, ctr: 24)] public string? _relativeFilePath = null;
        [FieldAttr(nst: 40, ctr: 32)] public string? _absoluteFilePath = null;
        [FieldAttr(nst: 48, ctr: 40)] public bool _autoCompatibility = true;
        [FieldAttr(nst: 49, ctr: 41)] public bool _IGBSharingState = true;
        [FieldAttr(nst: 52, ctr: 44)] public int _IGBChunkSize = 131072;
        [FieldAttr(nst: 56, ctr: 48)] public igReferenceResolverSet? _referenceResolverSet;
    }
}
