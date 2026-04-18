namespace Alchemy
{
    [ObjectAttr(nst: 304, align: 16)]
    public class CVfxLitSmokeMaterial : CVfxMaterial
    {
        [FieldAttr(nst: 272)] public float _lightWrap = 0.75f;
        [FieldAttr(nst: 288)] public igVec4fMetaField _lightWrapParameters = new();
    }
}
