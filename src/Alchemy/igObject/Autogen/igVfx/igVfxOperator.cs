namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 16, align: 8)]
    public class igVfxOperator : igObject
    {
        [ObjectAttr(size: 4)]
        public class OperatorFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _enabled = true;
            [FieldAttr(offset: 1, size: 1)] public bool _visualize = false;
            [FieldAttr(offset: 2, size: 1)] public bool _valid;
            [FieldAttr(offset: 3, size: 2)] public EStackType _stackType = EStackType.kStackEffect;
            [FieldAttr(offset: 5, size: 1)] public bool _dirty;
        }

        [FieldAttr(nst: 16, ctr: 12)] public OperatorFlags _operatorFlags = new();
    }
}
