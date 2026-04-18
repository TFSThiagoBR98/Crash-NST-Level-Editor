namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CKartCustomizationPreset : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _kart = new();
        [FieldAttr(ctr: 24)] public igHandleMetaField _colorScheme = new();
        [FieldAttr(ctr: 32)] public igHandleMetaField _decal = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _sticker = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _wheels = new();
    }
}
