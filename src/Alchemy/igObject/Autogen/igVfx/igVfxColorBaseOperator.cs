namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxColorBaseOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class ColorFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public EModulation _colorModulation = EModulation.kModulate;
            [FieldAttr(offset: 3, size: 3)] public EModulation _alphaModulation = EModulation.kReplace;
        }

        [FieldAttr(nst: 24, ctr: 16)] public ColorFlags _colorFlags = new();
    }
}
