namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CRacerCustomizationPreset : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _driver = new();
        [FieldAttr(ctr: 24)] public igHandleMetaField _skin = new();
        [FieldAttr(ctr: 32)] public igHandleMetaField _kartPreset = new();
    }
}
