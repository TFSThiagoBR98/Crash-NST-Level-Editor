namespace Alchemy
{
    [ObjectAttr(nst: 240, ctr: 240, align: 8)]
    public class igDirectory : igObjectList<igDirEntry>
    {
        [FieldAttr(nst: 40, ctr: 40)] public bool _loadPendingState;
        [FieldAttr(nst: 41, ctr: 41)] public bool _validState;
        [FieldAttr(nst: 42, ctr: 42)] public bool _compatibleState;
        [FieldAttr(nst: 44, ctr: 44)] public int _loadedRefCount;
        [FieldAttr(nst: 48, ctr: 48)] public bool _concreteState;
        [FieldAttr(nst: 56, ctr: 56)] public igReferenceResolverSet? _referenceResolverSet;
        [FieldAttr(nst: 64, ctr: 64)] public igReferenceResolverSet? _globalReferenceResolverSet;
        [FieldAttr(nst: 72, ctr: 72)] public string? _name = null;
        [FieldAttr(nst: 80, ctr: 80)] public igDirectoryList? _externalDirectoryList;
        [FieldAttr(nst: 88, ctr: 88)] public igInfoList? _infoList;
        [FieldAttr(nst: 96, ctr: 96, refCount: false)] public igResource? _managingResource;
        [FieldAttr(nst: 104, ctr: 104)] public igShortListList? _metaFieldPerObjectIndices;
        [FieldAttr(nst: 112, ctr: 112)] public bool _sharingState = true;
        [FieldAttr(nst: 113, ctr: 113)] public bool _trackUniqueEntries;
        [FieldAttr(nst: 120, ctr: 120)] public igDirectory? _uniqueEntryList;
        [FieldAttr(nst: 128, ctr: 128)] public igRawRefList? _refList;
        [FieldAttr(nst: 136, ctr: 136)] public igIntList? _alignmentList;
        [FieldAttr(nst: 144, ctr: 144)] public bool _autoWriteFilePreProcessState = true;
        [FieldAttr(nst: 145, ctr: 145)] public bool _useMemoryPoolAssignmentsState = true;
        [FieldAttr(nst: 146, ctr: 146)] public bool _forceWriteMemoryPoolInfoFromMetaState;
        [FieldAttr(nst: 152, ctr: 152)] public igStringRefList? _stringTable;
        [FieldAttr(nst: 160, ctr: 160)] public bool _stringRefCompatibilityMode;
        [FieldAttr(nst: 168, ctr: 168)] public igReferenceResolverContext? _resolverContext;
        [FieldAttr(nst: 176, ctr: 176)] public igObjectDirectory? _objectDirectory;
        [FieldAttr(nst: 184, ctr: 184)] public igVectorMetaField<igObjectDirectory> _dependencies = new();
        [FieldAttr(nst: 208, ctr: 208)] public igUnsignedIntStringHashTable? _handleNames;
        [FieldAttr(nst: 216, ctr: 216)] public igVectorMetaField<uint> _memoryPoolIndices = new();
    }
}
