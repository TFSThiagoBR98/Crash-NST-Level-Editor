namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class COutfitData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _skinsPackage;
        [FieldAttr(ctr: 24)] public string? _cutsceneSkinsPackage;
        [FieldAttr(ctr: 32)] public string? _cutsceneLoseSkinsPackage;
        [FieldAttr(ctr: 40)] public COutfitMaterialPackageList? _materialPackages;
        [FieldAttr(ctr: 48)] public string? _audioPackage;
    }
}
