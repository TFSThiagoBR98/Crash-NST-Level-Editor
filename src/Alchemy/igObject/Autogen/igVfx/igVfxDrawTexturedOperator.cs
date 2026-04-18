namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 56, align: 8)]
    public class igVfxDrawTexturedOperator : igVfxDrawOperator
    {
        [ObjectAttr(size: 4)]
        public class TexturedFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _lockMaskUVs;
        }

        [FieldAttr(nst: 32, ctr: 20)] public TexturedFlags _texturedFlags = new();
        [FieldAttr(nst: 40, ctr: 24)] public igHandleMetaField _material = new();
        [FieldAttr(nst: 48, ctr: 32)] public igVfxAnimatedFrame? _animatedFrame;
        [FieldAttr(nst: 56, ctr: 40)] public igVfxAnimatedFrame? _animatedFrameMask;
        [FieldAttr(nst: 64, ctr: 48)] public uint _animatedFrameInstance;
        [FieldAttr(nst: 68, ctr: 52)] public uint _animatedFrameMaskInstance;
    }
}
