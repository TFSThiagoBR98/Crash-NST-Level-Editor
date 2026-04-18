namespace Alchemy
{
    [ObjectAttr(nst: 184, ctr: 200, align: 8)]
    public class igObjectDirectory : igObject
    {
        public enum EFileType
        {
            kAuto = 0,
            kIGB = 1,
            kIGX = 2,
            kDataStream = 3,
            kIGZ = 4,
        }

        [FieldAttr(nst: 16, ctr: 16)] public igNameMetaField _name = new();
        [FieldAttr(nst: 32, ctr: 32)] public string? _path = null;
        [FieldAttr(nst: 40, ctr: 40)] public igObjectList? _objectList;
        [FieldAttr(nst: 48, ctr: 48)] public bool _useNameList = true;
        [FieldAttr(nst: 56, ctr: 56)] public igNameList? _nameList;
        [FieldAttr(nst: 64, ctr: 64)] public bool _useNamespaceList;
        [FieldAttr(nst: 72, ctr: 72)] public igNameList? _namespaceList;
        [FieldAttr(nst: 80, ctr: 80)] public igMemoryList? _memory;
        [FieldAttr(ctr: 88)] public igMemoryList? _workMemory;
        [FieldAttr(nst: 88, ctr: 96)] public igSizeTypeMetaField _memoryUsage = new();
        [FieldAttr(nst: 96, ctr: 104)] public igSizeTypeMetaField _childMemoryUsage = new();
        [FieldAttr(nst: 104, ctr: 112)] public igObject? _loaderData;
        [FieldAttr(nst: 112, ctr: 120)] public igObjectLoader? _loader;
        [FieldAttr(nst: 120, ctr: 128)] public EFileType _sourceFileType;
        [FieldAttr(nst: 124, ctr: 132)] public int _loadCount;
        [FieldAttr(nst: 128, ctr: 136)] public bool _allowMultipleInstances = true;
        [FieldAttr(ctr: 144)] public uint _fileParams;
        [FieldAttr(nst: 136, ctr: 152)] public igObjectList? _debugObjects;
        [FieldAttr(nst: 144, ctr: 160)] public igVectorMetaField<igObjectDirectory> _dependencies = new();
        [FieldAttr(nst: 168, ctr: 184)] public igThumbnailSet? _thumbnails;
        [FieldAttr(nst: 176, ctr: 192)] public igBaseMetaList? _createdMetas;
    }
}
