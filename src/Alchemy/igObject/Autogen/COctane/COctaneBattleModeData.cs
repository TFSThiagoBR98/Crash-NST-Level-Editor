namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class COctaneBattleModeData : igObject
    {
        [FieldAttr(ctr: 12)] public EOctaneRaceModes _battleMode;
        [FieldAttr(ctr: 16)] public igHandleMetaField _iconMaterial = new();
        [FieldAttr(ctr: 24)] public igHandleMetaField _menuImage = new();
        [FieldAttr(ctr: 32)] public igHandleMetaField _rightBackgroundImage = new();
    }
}
