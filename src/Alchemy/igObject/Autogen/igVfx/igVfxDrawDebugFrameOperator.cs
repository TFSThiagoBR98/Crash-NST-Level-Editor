namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igVfxDrawDebugFrameOperator : igVfxDrawOperator
    {
        [ObjectAttr(size: 4)]
        public class DebugFrameFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public EReferenceFrame _frame = EReferenceFrame.eRF_Instance;
            [FieldAttr(offset: 4, size: 1)] public bool _showColor;
            [FieldAttr(offset: 5, size: 1)] public bool _showVelocity;
        }

        [FieldAttr(nst: 32, ctr: 20)] public DebugFrameFlags _debugFrameFlags = new();
        [FieldAttr(nst: 36, ctr: 24)] public float _forceSize;
    }
}
