namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CutsceneActionApplyVisualData : CCutsceneAction
    {
        [FieldAttr(nst: 24, ctr: 24)] public float _duration = 2.0f;
        [FieldAttr(nst: 32, ctr: 32)] public CVisualDataGroup? _data;
    }
}
