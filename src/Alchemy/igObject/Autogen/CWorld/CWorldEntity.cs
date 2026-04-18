namespace Alchemy
{
    [ObjectAttr(nst: 216, ctr: 224, align: 8)]
    public class CWorldEntity : CEntity
    {
        [FieldAttr(nst: 144, ctr: 144)] public CWorldData? _worldData;
        [FieldAttr(nst: 152, ctr: 152)] public igVec3fMetaField _extentMin = new();
        [FieldAttr(nst: 164, ctr: 164)] public igVec3fMetaField _extentMax = new();
        [FieldAttr(nst: 176, ctr: 176)] public igHandleMetaField _spawnedCameraEffect = new();
        [FieldAttr(nst: 184, ctr: 184)] public bool _hasPoppedMagicMomentDisable;
        [FieldAttr(nst: 192, ctr: 192)] public igHandleMetaField _movingPushblock = new();
        [FieldAttr(nst: 200, ctr: 200)] public igHandleMetaField _surfaceVfxComponent = new();
        [FieldAttr(nst: 208, ctr: 208)] public EWorldGameplayMode _currentGameplayMode;
        [FieldAttr(ctr: 216)] public igHandleMetaField _splitscreenDialogBox = new();
    }
}
