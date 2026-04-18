namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class COctaneLevelSelectData : igObject
    {
        [FieldAttr(ctr: 12)] public igVec4ucMetaField _levelColor = new();
        [FieldAttr(ctr: 16)] public igHandleMetaField _levelIcon = new();
        [FieldAttr(ctr: 24)] public igHandleMetaField _levelBackground = new();
        [FieldAttr(ctr: 32)] public igHandleMetaField _scrollingBackgroundImage = new();
    }
}
