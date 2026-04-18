namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class common_LevelEndScene_CrateHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public EigEaseType _DropEaseType;
        [FieldAttr(nst: 44)] public float _DropTime;
        [FieldAttr(nst: 48)] public float _DropEaseRatioIn;
        [FieldAttr(nst: 52)] public float _DropEaseRatioOut;
        [FieldAttr(nst: 56)] public igHandleMetaField _SfxCrateDestroyData = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _VfxCrateDestroyData = new();
    }
}
