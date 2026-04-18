namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igShaderConstantValueList : igGraphicsObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igVectorMetaField<igShaderConstantValue> _values = new();
    }
}
