namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_AkuAkuMaskData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _MaskLightDuration;
        [FieldAttr(nst: 44)] public float _CameraLightDuration;
        [FieldAttr(nst: 48)] public igHandleMetaField _idleVFX = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _MaskLightVFX = new();
    }
}
