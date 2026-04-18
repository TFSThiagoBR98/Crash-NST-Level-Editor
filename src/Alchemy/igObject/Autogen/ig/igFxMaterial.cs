namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 120, align: 8)]
    public class igFxMaterial : igCustomMaterial
    {
        [FieldAttr(nst: 64, ctr: 64)] public string? _fxFilename = "";
        [FieldAttr(nst: 72, ctr: 72)] public igCachedAttrListList? _instanceAttrs;
        [FieldAttr(nst: 80, ctr: 80)] public igHandleMetaField _effectHandle = new();
        [FieldAttr(nst: 88, ctr: 88)] public igGraphicsMaterial? _graphicsMaterial;
        [FieldAttr(nst: 96, ctr: 96)] public uint _procVertexFormat = 49;
        [FieldAttr(nst: 100, ctr: 100)] public int _textureCoordCount = 1;
        [FieldAttr(nst: 104, ctr: 104)] public u64 _globalTechniqueMask;
        [FieldAttr(nst: 112, ctr: 112)] public igStringRefList? _filesLoaded;
    }
}
