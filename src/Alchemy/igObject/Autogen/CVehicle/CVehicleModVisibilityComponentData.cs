namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CVehicleModVisibilityComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public string? _modDiscriminator = "mod_";
    }
}
