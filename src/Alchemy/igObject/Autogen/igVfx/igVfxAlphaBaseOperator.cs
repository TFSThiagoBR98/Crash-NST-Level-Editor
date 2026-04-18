namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxAlphaBaseOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class ColorFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public EModulation _alphaModulation;
        }

        [FieldAttr(nst: 24, ctr: 16)] public ColorFlags _colorFlags = new();
    }
}
