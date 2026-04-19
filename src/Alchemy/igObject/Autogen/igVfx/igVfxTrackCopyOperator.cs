namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxTrackCopyOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class Flags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public EReferenceFrame _destinationTrack = EReferenceFrame.eRF_Track2;
            [FieldAttr(offset: 4, size: 1)] public bool _copyPose = false;
            [FieldAttr(offset: 5, size: 1)] public bool _copyMotion = false;
            [FieldAttr(offset: 6, size: 1)] public bool _copyColor = false;
            [FieldAttr(offset: 7, size: 1)] public bool _copySize = false;
            [FieldAttr(offset: 8, size: 1)] public bool _copyParameters;
        }

        [FieldAttr(nst: 24, ctr: 16)] public Flags _flags = new();
    }
}
