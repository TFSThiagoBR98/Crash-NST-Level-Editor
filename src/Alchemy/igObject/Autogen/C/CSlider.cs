namespace Alchemy
{
    [ObjectAttr(nst: 136, ctr: 136, align: 8, meta: true)]
    public class CSlider : Object
    {
        public enum EState
        {
            eSTT_Standby = 0,
            eSTT_Active = 1,
            eSTT_Done = 2,
        }

        [ObjectAttr(size: 4)]
        public class FlagsBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public CSlider.EState _currentState;
            [FieldAttr(offset: 3, size: 1)] public bool _isPaused;
            [FieldAttr(offset: 4, size: 1)] public bool _isScriptObject;
        }

        [FieldAttr(nst: 32, ctr: 32)] public float _startingValue;
        [FieldAttr(nst: 36, ctr: 36)] public float _endingValue;
        [FieldAttr(nst: 40, ctr: 40)] public float _totalDuration;
        [FieldAttr(nst: 44, ctr: 44)] public float _easeInDuration;
        [FieldAttr(nst: 48, ctr: 48)] public float _easeOutDuration;
        [FieldAttr(nst: 52, ctr: 52)] public EigEaseType _easeType = EigEaseType.kEaseTypeQuadratic;
        [FieldAttr(nst: 56, ctr: 56)] public ESliderMode _mode;
        [FieldAttr(nst: 60, ctr: 60)] public FlagsBitfield _flagsBitfield = new();
        [FieldAttr(nst: 64, ctr: 64)] public bool _reversed;
        [FieldAttr(nst: 65, ctr: 65)] public bool _networkReversed;
        [FieldAttr(nst: 68, ctr: 68)] public float _value;
        [FieldAttr(nst: 72, ctr: 72)] public float _timeElapsed;
        [FieldAttr(nst: 76, ctr: 76)] public bool _replicated = true;
        [FieldAttr(nst: 80, ctr: 80)] public u64 _sliderNodeID;
        [FieldAttr(nst: 88, ctr: 88)] public float _netTimeElapsedTolerance = 0.1f;
        [FieldAttr(nst: 96, ctr: 96)] public igHandleMetaField _entity = new();
        [FieldAttr(nst: 104, ctr: 104)] public igHandleMetaField _callbackOwner = new();
        [FieldAttr(nst: 112)] public igRawRefMetaField _onUpdate = new();
        [FieldAttr(nst: 120)] public igRawRefMetaField _onCompletion = new();
        [FieldAttr(nst: 128)] public igRawRefMetaField _onStartReached = new();
    }
}
