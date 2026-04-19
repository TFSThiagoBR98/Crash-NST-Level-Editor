namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxSizeBaseOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class SizeFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public EModulation _modulation = EModulation.kModulate;
        }

        [FieldAttr(nst: 24, ctr: 16)] public SizeFlags _sizeFlags = new();
    }
}
