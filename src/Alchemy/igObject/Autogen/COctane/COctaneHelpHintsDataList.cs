namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class COctaneHelpHintsDataList : igObjectList<COctaneHelpHintsData>
    {
        [FieldAttr(ctr: 40)] public string? _categoryName;
    }
}
