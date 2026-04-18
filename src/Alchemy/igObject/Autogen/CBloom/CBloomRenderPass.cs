namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 128, align: 8)]
    public class CBloomRenderPass : igRenderPass
    {
        [FieldAttr(nst: 56, ctr: 56)] public igHandleMetaField _bloomMaterial = new();
        [FieldAttr(nst: 64, ctr: 64)] public igHandleMetaField _bloomUpsampleMaterial = new();
        [FieldAttr(nst: 72, ctr: 72)] public string? _downsample0Technique = "Downsample0";
        [FieldAttr(nst: 80, ctr: 80)] public string? _downsample1Technique = "Downsample1";
        [FieldAttr(nst: 88, ctr: 88)] public string? _downsample2Technique = "Downsample2";
        [FieldAttr(nst: 96, ctr: 96)] public string? _upsampleTechnique = "Upsample";
        [FieldAttr(nst: 104, ctr: 104)] public igHandleMetaField _inputRenderTarget = new();
        [FieldAttr(nst: 112, ctr: 112)] public igHandleMetaField _maskRenderTarget = new();
        [FieldAttr(nst: 120, ctr: 120)] public igHandleMetaField _outputRenderTarget = new();
    }
}
