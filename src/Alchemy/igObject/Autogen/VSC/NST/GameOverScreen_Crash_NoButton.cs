namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class GameOverScreen_Crash_NoButton : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Zone_Info = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _LoadMapFadeOut = new();
    }
}
