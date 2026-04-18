namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CModSoundEventData : igObject
    {
        [FieldAttr(nst: 16)] public CMod.EModLocation _modLocation = CMod.EModLocation.eML_Invalid;
        [FieldAttr(nst: 20)] public ESoundLoopEvent _loopEvent;
        [FieldAttr(nst: 24)] public CSoundUpdateMethodList? _updateMethodList;
        [FieldAttr(nst: 32)] public bool _playNameVO;
        [FieldAttr(nst: 33)] public bool _playTaglineVO;
        [FieldAttr(nst: 34)] public bool _playIdleSfx;
        [FieldAttr(nst: 35)] public bool _playOneShotSfx;
    }
}
