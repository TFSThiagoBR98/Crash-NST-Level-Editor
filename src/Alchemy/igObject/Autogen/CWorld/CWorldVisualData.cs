namespace Alchemy
{
    [ObjectAttr(nst: 152, ctr: 176, align: 8)]
    public class CWorldVisualData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVec3fMetaField _windDirection = new();
        [FieldAttr(nst: 32, ctr: 24)] public string? _cloudCoverTextureName = "loosetextures";
        [FieldAttr(nst: 40, ctr: 32)] public string? _specularEnvironmentMap = "loosetextures";
        [FieldAttr(nst: 48, ctr: 40)] public string? _environmentMap = null;
        [FieldAttr(ctr: 48)] public CEnvironmentMapData? _environmentMap1;
        [FieldAttr(ctr: 56)] public CEnvironmentMapData? _environmentMap2;
        [FieldAttr(ctr: 64)] public CEnvironmentMapData? _environmentMap3;
        [FieldAttr(ctr: 72)] public bool _screenSpaceReflectionsEnabled;
        [FieldAttr(ctr: 73)] public bool _skyGradientEnabled;
        [FieldAttr(nst: 56, ctr: 80)] public CDistantGeometryModelNameList? _farSkyModelList;
        [FieldAttr(nst: 64, ctr: 88)] public CDistantGeometryModelNameList? _nearSkyModelList;
        [FieldAttr(nst: 72, ctr: 96)] public CWorldVisualDataGroup? _defaultGroup;
        [FieldAttr(nst: 80, ctr: 104)] public string? _nearSkyModelName = null;
        [FieldAttr(nst: 88, ctr: 112)] public string? _farSkyModelName1 = null;
        [FieldAttr(nst: 96, ctr: 120)] public string? _farSkyModelName2 = null;
        [FieldAttr(nst: 104, ctr: 128)] public string? _farSkyModelName3 = null;
        [FieldAttr(nst: 112, ctr: 136)] public string? _farSkyModelName4 = null;
        [FieldAttr(nst: 120, ctr: 144)] public CSkyboxModelsHashTable? _skyboxModelsHashTable;
        [FieldAttr(nst: 128, ctr: 152)] public igObjectDirectory? _cloudCoverTextureDirectory;
        [FieldAttr(nst: 136, ctr: 160)] public igObjectDirectory? _specularEnvironmentMapDirectory;
        [FieldAttr(nst: 144, ctr: 168)] public igObjectDirectory? _environmentMapDirectory;
    }
}
