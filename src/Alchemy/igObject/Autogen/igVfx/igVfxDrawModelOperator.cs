namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class igVfxDrawModelOperator : igVfxDrawOperator
    {
        [FieldAttr(nst: 32, ctr: 24)] public string? _modelNameInternal = null;
        [FieldAttr(nst: 40, ctr: 32)] public igHandleMetaField _sceneHandle = new();
        [FieldAttr(nst: 48, ctr: 40)] public igModelData? _modelData;
        [FieldAttr(nst: 56, ctr: 48)] public bool _fitToScale;
        [FieldAttr(nst: 60, ctr: 52)] public uint _instanceData;
        [FieldAttr(nst: 64, ctr: 56, refCount: false)] public igRenderer? _renderer;
    }
}
