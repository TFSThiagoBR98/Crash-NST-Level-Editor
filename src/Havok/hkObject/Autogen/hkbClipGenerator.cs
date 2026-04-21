using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 352, ctr: 352)]
    public class hkbClipGenerator : hkbGenerator
    {
        public override uint Hash => 0xd4cc9f6;

        [FieldAttr(nst: 136, ctr: 136)] public string? _animationBundleName;
        [FieldAttr(nst: 144, ctr: 144)] public string? _animationName;
        [FieldAttr(nst: 152, ctr: 152)] public hkbClipTriggerArray? _triggers;
        [FieldAttr(nst: 160, ctr: 160)] public uint _userPartitionMask;
        [FieldAttr(nst: 164, ctr: 164)] public float _cropStartAmountLocalTime;
        [FieldAttr(nst: 168, ctr: 168)] public float _cropEndAmountLocalTime;
        [FieldAttr(nst: 172, ctr: 172)] public float _startTime;
        [FieldAttr(nst: 176, ctr: 176)] public float _playbackSpeed;
        [FieldAttr(nst: 180, ctr: 180)] public float _enforcedDuration;
        [FieldAttr(nst: 184, ctr: 184)] public float _userControlledTimeFraction;
        [FieldAttr(nst: 188, ctr: 188)] public i16 _animationBindingIndex;
        [FieldAttr(nst: 190, ctr: 190)] public EPlaybackMode _mode;
        [FieldAttr(nst: 191, ctr: 191)] public i8 _flags;
        [FieldAttr(nst: 192, ctr: 192)] public hkMemory<uint> _animDatas;
        [FieldAttr(nst: 208, ctr: 208)] public uint _animationControl;
        [FieldAttr(nst: 216, ctr: 216)] public hkbClipTriggerArray? _originalTriggers;
        [FieldAttr(nst: 224, ctr: 224)] public uint _mapperData;
        [FieldAttr(nst: 232, ctr: 232)] public hkaAnimationBinding? _binding;
        [FieldAttr(nst: 240, ctr: 240)] public int _numAnimationTracks;
        [FieldAttr(nst: 256, ctr: 256)] public Matrix3x4 _extractedMotion;
        [FieldAttr(nst: 304, ctr: 304)] public hkMemory<uint> _echos;
        [FieldAttr(nst: 320, ctr: 320)] public float _localTime;
        [FieldAttr(nst: 324, ctr: 324)] public float _time;
        [FieldAttr(nst: 328, ctr: 328)] public float _previousUserControlledTimeFraction;
        [FieldAttr(nst: 332, ctr: 332)] public int _bufferSize;
        [FieldAttr(nst: 336, ctr: 336)] public bool _atEnd;
        [FieldAttr(nst: 337, ctr: 337)] public bool _ignoreStartTime;
        [FieldAttr(nst: 338, ctr: 338)] public bool _pingPongBackward;
    }
}