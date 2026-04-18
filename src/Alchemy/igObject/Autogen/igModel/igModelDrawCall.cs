namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 128, align: 16)]
    public class igModelDrawCall : igDrawCall
    {
        [FieldAttr(nst: 24, ctr: 16, refCount: false)] public igModelDrawCallData? _data;
        [FieldAttr(nst: 32, ctr: 24)] public igMatrix44fMetaField _transform = new();
        [FieldAttr(nst: 40, ctr: 32)] public igMatrix44fMetaField _transformPrevious = new();
        [FieldAttr(nst: 48, ctr: 40)] public igVec4fMetaField _morphWeights = new();
        [FieldAttr(nst: 56, ctr: 48)] public igVec4fMetaField _morphWeightsPrevious = new();
        [FieldAttr(nst: 64, ctr: 56, refCount: false)] public igGraphicsMaterial? _material;
        [FieldAttr(nst: 72, ctr: 64)] public int _stencilRef;
        [FieldAttr(nst: 80, ctr: 72, refCount: false)] public igShaderConstantBundleList? _constantBundles;
        [FieldAttr(nst: 88, ctr: 80)] public int _dynamicConstantBundles;
        [FieldAttr(nst: 96, ctr: 88, refCount: false)] public igShaderConstantBundleList? _dataConstantBundles;
        [FieldAttr(nst: 104, ctr: 96, refCount: false)] public igModelInstance? _instance;
        [FieldAttr(nst: 112, ctr: 104)] public igTimeMetaField _instanceTime = new();
        [FieldAttr(nst: 116, ctr: 108)] public float[] _fadeLevels = new float[4];
        [FieldAttr(nst: 124, ctr: 124)] public int _visited;
    }
}
