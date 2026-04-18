namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 16)]
    public class igFont : igNamedObject
    {
        public enum EHorizontalAlignment
        {
            kHorizontalAlignmentLeft = 0,
            kHorizontalAlignmentRight = 1,
            kHorizontalAlignmentCenter = 2,
        }

        public enum EVerticalAlignment
        {
            kVerticalAlignmentTop = 0,
            kVerticalAlignmentCenter = 1,
            kVerticalAlignmentBottom = 2,
        }

        [FieldAttr(nst: 24, ctr: 24)] public float _height;
        [FieldAttr(nst: 28, ctr: 28)] public float _blankLineSize = 1.0f;
        [FieldAttr(nst: 32, ctr: 32)] public float _baseLine;
        [FieldAttr(nst: 40, ctr: 40)] public igAttrList? _attrList;
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 64, ctr: 64)] public float _charPadding;
        [FieldAttr(nst: 68, ctr: 68)] public bool _useNonbreakingUnderscore = true;
    }
}
