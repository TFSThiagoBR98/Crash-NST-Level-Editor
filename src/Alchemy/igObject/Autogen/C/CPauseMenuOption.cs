namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class CPauseMenuOption : igLocalizedNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public string? _description = null;
        [FieldAttr(nst: 32, ctr: 32)] public igHandleMetaField _effect = new();
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _configureAnimation = new();
        [FieldAttr(nst: 48, ctr: 48)] public igHandleMetaField _leftArrowPressedAnimation = new();
        [FieldAttr(nst: 56, ctr: 56)] public igHandleMetaField _rightArrowPressedAnimation = new();
        [FieldAttr(nst: 64, ctr: 64)] public igHandleMetaField _selectAnimation = new();
        [FieldAttr(nst: 72, ctr: 72)] public igHandleMetaField _detailsImageMaterial = new();
        [FieldAttr(nst: 80, ctr: 80)] public CGuiBehaviorPauseMenuOption? _behavior;
    }
}
