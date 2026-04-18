namespace Alchemy
{
    [ObjectAttr(ctr: 176, align: 8)]
    public class CKartCustomizationComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public string? _kartName;
        [FieldAttr(ctr: 24)] public igFxMaterialHandleList? _colorSchemeMaterialKeys;
        [FieldAttr(ctr: 32)] public igHandleMetaField _defaultColorScheme = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _stickerMaterialKey = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _decalMaterialKey = new();
        [FieldAttr(ctr: 56)] public CBoltPoint? _wheelFrontLeftBolt;
        [FieldAttr(ctr: 64)] public CBoltPoint? _wheelFrontRightBolt;
        [FieldAttr(ctr: 72)] public CBoltPoint? _wheelBackLeftBolt;
        [FieldAttr(ctr: 80)] public CBoltPoint? _wheelBackRightBolt;
        [FieldAttr(ctr: 88)] public CGameEntity? _wheelBackRightWheel;
        [FieldAttr(ctr: 96)] public CGameEntity? _wheelBackLeftWheel;
        [FieldAttr(ctr: 104)] public CGameEntity? _wheelFrontLeftWheel;
        [FieldAttr(ctr: 112)] public CGameEntity? _wheelFrontRightWheel;
        [FieldAttr(ctr: 120)] public CBoltPoint? _wheelEffectFrontLeftBolt;
        [FieldAttr(ctr: 128)] public CBoltPoint? _wheelEffectFrontRightBolt;
        [FieldAttr(ctr: 136)] public CBoltPoint? _wheelEffectBackLeftBolt;
        [FieldAttr(ctr: 144)] public CBoltPoint? _wheelEffectBackRightBolt;
        [FieldAttr(ctr: 152)] public CGameEntity? _detachableWheelData;
        [FieldAttr(ctr: 160)] public bool _createWheelsOnEnable;
        [FieldAttr(ctr: 164)] public float _frontWheelScale;
        [FieldAttr(ctr: 168)] public float _backWheelScale;
        [FieldAttr(ctr: 172)] public uint _wheelSpawnFlags;
    }
}
