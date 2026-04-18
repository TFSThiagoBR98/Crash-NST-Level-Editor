namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 8)]
    public class SurfaceVfxSpec : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _materialHandle = new();
        [FieldAttr(ctr: 24)] public igVfxEffect? _surfaceVfx;
        [FieldAttr(ctr: 32)] public igVfxEffect? _nonLocalSurfaceVfx;
        [FieldAttr(ctr: 40)] public bool _shouldTriggerSurfaceSound;
        [FieldAttr(ctr: 48)] public igHandleMetaField _surfaceSfx = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _nonLocalSurfaceSfx = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _oneShotSurfaceSfx = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _nonLocalOneShotSurfaceSfx = new();
        [FieldAttr(ctr: 80)] public CSoundUpdateMethodList? _sfxUpdateMethodList;
    }
}
