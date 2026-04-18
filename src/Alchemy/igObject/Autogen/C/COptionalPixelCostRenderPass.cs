namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class COptionalPixelCostRenderPass : igRenderPass
    {
        [FieldAttr(nst: 56, ctr: 56)] public igHandleMetaField _enabledData = new();
        [FieldAttr(nst: 64, ctr: 64)] public uint _mode;
        [FieldAttr(nst: 68, ctr: 68)] public bool _ignoreMode;
    }
}
