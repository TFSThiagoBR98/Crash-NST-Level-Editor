namespace Alchemy
{
    [ObjectAttr(ctr: 144, align: 16)]
    public class CTintSphereBundle : igShaderConstantBundle
    {
        [FieldAttr(ctr: 32)] public igMatrix44fMetaField _inverseModelMatrix = new();
        [FieldAttr(ctr: 96)] public igVec4fMetaField _color = new();
        [FieldAttr(ctr: 112)] public float _fadingDistance;
        [FieldAttr(ctr: 116)] public float _fadingRange;
        [FieldAttr(ctr: 120)] public float _additiveness;
        [FieldAttr(ctr: 124)] public float _invDepthSoftness;
        [FieldAttr(ctr: 128)] public bool _depthBlendingEnabled;
    }
}
