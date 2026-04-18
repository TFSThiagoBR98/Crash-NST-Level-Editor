namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CPointLightComponent : igComponent
    {
        [FieldAttr(ctr: 40)] public igRenderPointLight? _light;
        [FieldAttr(ctr: 48)] public uint _flags;
        [FieldAttr(ctr: 52)] public bool _lightComponentEnabled;
    }
}
