namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igTextureSamplerSource : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public uint _textureUnit;
        [FieldAttr(nst: 28, ctr: 28)] public uint _samplerNumber;
        [FieldAttr(nst: 32, ctr: 32)] public uint _reserved;
    }
}
