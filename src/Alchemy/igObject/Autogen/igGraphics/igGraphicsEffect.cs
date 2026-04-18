namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 8)]
    public class igGraphicsEffect : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igIntList? _globalTechniqueList;
        [FieldAttr(nst: 32, ctr: 32)] public u64 _globalTechniqueMask;
        [FieldAttr(nst: 40, ctr: 40)] public igGraphicsObjectSet? _graphicsObjects;
        [FieldAttr(nst: 48, ctr: 48)] public igStringRefList? _techniqueNames;
        [FieldAttr(nst: 56, ctr: 56)] public igMemoryCommandStreamList? _commandStreams;
        [FieldAttr(nst: 64, ctr: 64)] public igUnsignedIntList? _combinedTechniqueFlags;
        [FieldAttr(nst: 72, ctr: 72)] public uint _procVertexFormat;
    }
}
