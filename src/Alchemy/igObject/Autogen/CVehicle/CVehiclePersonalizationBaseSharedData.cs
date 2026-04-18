namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CVehiclePersonalizationBaseSharedData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public EVehiclePersonalizationType _type = EVehiclePersonalizationType.eVPT_None;
        [FieldAttr(nst: 24, ctr: 16)] public igHandleMetaField _iconGuiMaterial = new();
        [FieldAttr(nst: 32, ctr: 24)] public string? _guiName = null;
    }
}
