namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class igGraphicsVertexShader : igGraphicsShader
    {
        [FieldAttr(nst: 56, ctr: 56)] public igVertexDataList? _inputList;
        [FieldAttr(nst: 64, ctr: 64)] public bool _exportShader;
    }
}
