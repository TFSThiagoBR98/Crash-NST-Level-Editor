namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxTextureTransformSimpleOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class Flags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _diffuse = true;
            [FieldAttr(offset: 1, size: 1)] public bool _mask;
            [FieldAttr(offset: 2, size: 3)] public ERotate _uvRotation;
            [FieldAttr(offset: 5, size: 2)] public EMirror _uMirror;
            [FieldAttr(offset: 7, size: 2)] public EMirror _vMirror;
        }

        [FieldAttr(nst: 24, ctr: 16)] public Flags _flags = new();
    }
}
