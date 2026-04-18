namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CVehicleModVfxComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CVehicleModeVfxDataListList? _primaryMods;
        [FieldAttr(nst: 32)] public CVehicleModeVfxDataListList? _secondaryMods;
        [FieldAttr(nst: 40)] public CVehicleModeVfxDataList? _superChargedMod;
    }
}
