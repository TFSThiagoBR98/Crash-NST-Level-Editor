namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class COctaneDriverWinsUnlockable : COctaneUnlockable
    {
        [FieldAttr(ctr: 32)] public string? _driverName;
        [FieldAttr(ctr: 40)] public int _winCount;
    }
}
