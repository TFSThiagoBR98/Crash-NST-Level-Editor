namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igDepthEncodingBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 24, ctr: 24)] public float _farPlane = 1.0f;
        [FieldAttr(nst: 28, ctr: 28)] public float _farDiv255 = 39.21569061f;
        [FieldAttr(nst: 32, ctr: 32)] public float _oneDivFarPlane = 0.0f;
        [FieldAttr(nst: 36, ctr: 36)] public float _255DivFarPlane = 0.0255f;
    }
}
