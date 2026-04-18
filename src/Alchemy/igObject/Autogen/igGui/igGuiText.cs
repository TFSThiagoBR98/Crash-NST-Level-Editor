namespace Alchemy
{
    [ObjectAttr(nst: 176, ctr: 176, align: 16)]
    public class igGuiText : igGuiAsset
    {
        public enum ECapsMode
        {
            kDefault = 0,
            kForceUpperCase = 1,
            kForceLowerCase = 2,
        }

        [FieldAttr(nst: 32, ctr: 32)] public igHandleMetaField _font = new();
        [FieldAttr(nst: 40, ctr: 40)] public ECapsMode _capsMode;
        [FieldAttr(nst: 48, ctr: 48)] public igHandleMetaField _material = new();
        [FieldAttr(nst: 56, ctr: 56)] public igHandleMetaField _shadowMaterial = new();
        [FieldAttr(nst: 64, ctr: 64)] public igText.EColorMode _colorMode;
        [FieldAttr(nst: 68, ctr: 68)] public igVec3fMetaField _modifierColorA = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec3fMetaField _modifierColorB = new();
        [FieldAttr(nst: 92, ctr: 92)] public igFont.EHorizontalAlignment _horizontalAlignment;
        [FieldAttr(nst: 96, ctr: 96)] public igFont.EVerticalAlignment _verticalAlignment;
        [FieldAttr(nst: 100, ctr: 100)] public float _fontScale = 1.0f;
        [FieldAttr(nst: 104, ctr: 104)] public bool _forceFitInBox;
        [FieldAttr(nst: 105, ctr: 105)] public bool _wordWrap;
        [FieldAttr(nst: 108, ctr: 108)] public float _leading;
        [FieldAttr(nst: 112, ctr: 112)] public float _tracking;
        [FieldAttr(nst: 116, ctr: 116)] public bool _shadow;
        [FieldAttr(nst: 120, ctr: 120)] public igVec2fMetaField _shadowOffset = new();
        [FieldAttr(nst: 128, ctr: 128)] public igVec3fMetaField _shadowColor = new();
        [FieldAttr(nst: 140, ctr: 140)] public float _shadowAlpha = 1.0f;
        [FieldAttr(nst: 144, ctr: 144, refCount: false)] public igText? _renderText;
        [FieldAttr(nst: 152, ctr: 152)] public igVec2fMetaField _finalFontScale = new();
        [FieldAttr(nst: 160, ctr: 160)] public string? _previousDisplayText = null;
        [FieldAttr(nst: 168, ctr: 168)] public string? _textInternal = null;
    }
}
