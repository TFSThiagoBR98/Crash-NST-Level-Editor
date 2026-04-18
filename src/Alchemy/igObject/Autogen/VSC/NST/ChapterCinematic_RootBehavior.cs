namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(igGuiVscBehavior))]
    public class ChapterCinematic_RootBehavior : igGuiVscBehavior
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _IntroOutroAnimation = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _ChapterNamePlaceable = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _GuiPlaceableVariable_variable = new();
        [FieldAttr(nst: 64)] public string? _ChapterName = null;
        [FieldAttr(nst: 72)] public string? _CheckpointName = null;
    }
}
