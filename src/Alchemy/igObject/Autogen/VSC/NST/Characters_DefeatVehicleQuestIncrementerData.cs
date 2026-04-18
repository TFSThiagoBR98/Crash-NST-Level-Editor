namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class Characters_DefeatVehicleQuestIncrementerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _SpecifiedAttackIdentifier = null;
        [FieldAttr(nst: 48)] public string? _CustomEvent = null;
    }
}
