namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 16)]
    public class igRenderPointLight : igRenderLight
    {
        [FieldAttr(ctr: 68)] public igVec2fMetaField _attenuation = new();
        [FieldAttr(ctr: 76)] public bool _distanceCull;
        [FieldAttr(ctr: 77)] public u8 _forceViewportDisableFlags;
    }
}
