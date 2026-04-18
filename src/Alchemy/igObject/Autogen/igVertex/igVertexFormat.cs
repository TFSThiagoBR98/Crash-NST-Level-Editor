namespace Alchemy
{
    [ObjectAttr(nst: 136, ctr: 128, align: 8)]
    public class igVertexFormat : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public uint _vertexSize;
        [FieldAttr(nst: 24, ctr: 16)] public igMemoryRef<igVertexElementMetaField> _elements = new();
        [FieldAttr(nst: 40, ctr: 32)] public igMemoryRef<u8> _platformData = new();
        [FieldAttr(nst: 56, ctr: 48)] public EIG_GFX_PLATFORM _platform;
        [FieldAttr(nst: 64, ctr: 56)] public igVertexFormat? _softwareBlendedFormat;
        [FieldAttr(nst: 72, ctr: 64)] public igVertexBlender? _blender;
        [FieldAttr(nst: 80, ctr: 72)] public bool _dynamic;
        [FieldAttr(nst: 88, ctr: 80)] public igVertexFormatPlatform? _platformFormat;
        [FieldAttr(nst: 96, ctr: 88)] public igMemoryRef<igVertexStreamMetaField> _streams = new();
        [FieldAttr(nst: 112, ctr: 104)] public uint _hashCode;
        [FieldAttr(nst: 120, ctr: 112)] public igVertexFormat? _softwareBlendedMultistreamFormat;
        [FieldAttr(nst: 128, ctr: 120)] public bool _enableSoftwareBlending = true;
        [FieldAttr(nst: 132, ctr: 124)] public uint _cachedUsage;
    }
}
