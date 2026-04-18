namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class common_PowerUpCrateData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Vfx_Effect_0x20 = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Vfx_Effect_0x28 = new();
        [FieldAttr(ctr: 48)] public EThemeSFXType _E_Theme_SFX_Type_0x30;
        [FieldAttr(ctr: 52)] public EThemeSFXType _E_Theme_SFX_Type_0x34;
    }
}
