namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CUnlockablePackageFirstParty : igObject
    {
        [FieldAttr(ctr: 16)] public string? _code;
        [FieldAttr(ctr: 24)] public string? _productName;
        [FieldAttr(ctr: 32)] public uint _bitfield;
        [FieldAttr(ctr: 36)] public EMSPlatform _platform;
        [FieldAttr(ctr: 40)] public CUnlockablePackageList? _packages;
    }
}
