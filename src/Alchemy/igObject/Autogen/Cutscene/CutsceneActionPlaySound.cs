namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CutsceneActionPlaySound : CCutsceneAction
    {
        [FieldAttr(nst: 24, ctr: 24)] public CSound? _sound;
        [FieldAttr(nst: 32, ctr: 32)] public bool _playAtEnd;
        [FieldAttr(nst: 33, ctr: 33)] public bool _continueAfterEnd;
    }
}
