namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CBoxLightComponent : igComponent
    {
        [FieldAttr(ctr: 40)] public CBoxLight? _light;
        [FieldAttr(ctr: 48)] public bool _lightState;
        [FieldAttr(ctr: 49)] public bool _lightComponentEnabled;
    }
}
