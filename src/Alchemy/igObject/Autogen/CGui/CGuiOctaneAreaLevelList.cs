namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CGuiOctaneAreaLevelList : igObjectList<CGuiOctaneLevelData>
    {
        [FieldAttr(ctr: 40)] public string? _areaName;
    }
}
