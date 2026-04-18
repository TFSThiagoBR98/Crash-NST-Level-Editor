namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CQueuedGameSound : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _sound = new();
        [FieldAttr(ctr: 24)] public igHandleMetaField _entity = new();
        [FieldAttr(ctr: 32)] public igVec3fMetaField _position = new();
        [FieldAttr(ctr: 44)] public igTimeMetaField _queuedTime = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _gameSoundInstance = new();
    }
}
