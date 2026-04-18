namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CutsceneActionSetVisibility : CCutsceneAction
    {
        [FieldAttr(nst: 24, ctr: 24)] public CCutsceneActor? _actor;
        [FieldAttr(nst: 32, ctr: 32)] public bool _isVisible;
    }
}
