namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 112, align: 16)]
    public class igViewPositionReconstructionBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _reconstructionConstants = new();
        [FieldAttr(nst: 48, ctr: 48)] public igMatrix44fMetaField _inverseViewMatrix = new();
    }
}
