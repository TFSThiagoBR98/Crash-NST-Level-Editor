namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxTrackCopyDetailedOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class Flags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public EReferenceFrame _destinationTrack = EReferenceFrame.eRF_Track2;
            [FieldAttr(offset: 4, size: 1)] public bool _copyOrientation = false;
            [FieldAttr(offset: 5, size: 1)] public bool _copyPosition = false;
            [FieldAttr(offset: 6, size: 1)] public bool _copySpin = false;
            [FieldAttr(offset: 7, size: 1)] public bool _copyVelocity = false;
            [FieldAttr(offset: 8, size: 1)] public bool _copyColor = false;
            [FieldAttr(offset: 9, size: 1)] public bool _copySize = false;
            [FieldAttr(offset: 10, size: 1)] public bool _copyParameter1;
            [FieldAttr(offset: 11, size: 1)] public bool _copyParameter2;
            [FieldAttr(offset: 12, size: 1)] public bool _copyParameter3;
            [FieldAttr(offset: 13, size: 1)] public bool _copyParameter4;
        }

        [FieldAttr(nst: 24, ctr: 16)] public Flags _flags = new();
    }
}
