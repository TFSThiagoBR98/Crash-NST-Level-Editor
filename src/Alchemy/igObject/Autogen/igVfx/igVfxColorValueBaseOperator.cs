namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 24, align: 8)]
    public class igVfxColorValueBaseOperator : igVfxFrameOperator
    {
        public enum EMode
        {
            kValue = 0,
            kLightness = 1,
            kSaturation = 2,
        }

        [ObjectAttr(size: 4)]
        public class ColorValueFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 2)] public igVfxColorValueBaseOperator.EMode _mode;
            [FieldAttr(offset: 2, size: 3)] public EModulation _modulation;
        }

        [FieldAttr(nst: 32, ctr: 20)] public ColorValueFlags _colorValueFlags = new();
    }
}
