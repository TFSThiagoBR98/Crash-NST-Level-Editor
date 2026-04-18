namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CShowroomCharacterKeyFrameData : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _characterEntity = new();
        [FieldAttr(ctr: 24)] public CEntityHandleList? _characterSkinsEntity;
        [FieldAttr(ctr: 32)] public string? _characterName;
        [FieldAttr(ctr: 40)] public string? _animName;
        [FieldAttr(ctr: 48)] public int _animationFirstFrame;
        [FieldAttr(ctr: 52)] public int _animationLastFrame;
        [FieldAttr(ctr: 56)] public igIntList? _animationKeysFrame;
    }
}
