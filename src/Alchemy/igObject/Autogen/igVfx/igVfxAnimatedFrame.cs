namespace Alchemy
{
    [ObjectAttr(nst: 296, ctr: 288, align: 8)]
    public class igVfxAnimatedFrame : igObject
    {
        public enum EAnimatedFrameLoopMode
        {
            kLoopNone = 0,
            kLoopLoop = 1,
            kLoopPingPong = 2,
            kLoopReverse = 3,
        }

        public enum EAnimatedFrameRotation
        {
            kRotationNone = 0,
            kRotation90 = 1,
            kRotation180 = 2,
            kRotation270 = 3,
            kRotationRandom = 4,
        }

        public enum EAnimatedFrameMirror
        {
            kMirrorNone = 0,
            kMirrorReverse = 1,
            kMirrorRandom = 2,
        }

        [ObjectAttr(size: 2)]
        public class Flags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 2)] public igVfxAnimatedFrame.EAnimatedFrameLoopMode _loopMode;
            [FieldAttr(offset: 2, size: 3)] public igVfxAnimatedFrame.EAnimatedFrameRotation _uvRotation;
            [FieldAttr(offset: 5, size: 2)] public igVfxAnimatedFrame.EAnimatedFrameMirror _uMirror;
            [FieldAttr(offset: 7, size: 2)] public igVfxAnimatedFrame.EAnimatedFrameMirror _vMirror;
            [FieldAttr(offset: 9, size: 1)] public bool _enabled;
            [FieldAttr(offset: 10, size: 1)] public bool _randomStart;
            [FieldAttr(offset: 11, size: 1)] public bool _uvScrollEnabled;
        }

        [FieldAttr(nst: 16, ctr: 12)] public Flags _flags = new();
        [FieldAttr(nst: 20, ctr: 16)] public igVfxRangedCurveMetaField _framesPerSecond = new();
        [FieldAttr(nst: 104, ctr: 100)] public u8 _rows = 1;
        [FieldAttr(nst: 105, ctr: 101)] public u8 _columns = 1;
        [FieldAttr(nst: 108, ctr: 104)] public float _scrollTime;
        [FieldAttr(nst: 112, ctr: 108)] public igVfxRangedCurveMetaField _uScrollOffset = new();
        [FieldAttr(nst: 196, ctr: 192)] public igVfxRangedCurveMetaField _vScrollOffset = new();
        [FieldAttr(nst: 280, ctr: 276)] public bool _useFrameRange;
        [FieldAttr(nst: 284, ctr: 280)] public uint _startFrame;
        [FieldAttr(nst: 288, ctr: 284)] public uint _endFrame;
    }
}
