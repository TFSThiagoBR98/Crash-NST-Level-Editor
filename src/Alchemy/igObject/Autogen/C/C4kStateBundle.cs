namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class C4kStateBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 24, ctr: 24)] public bool _state;
    }
}
