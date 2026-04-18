namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 16)]
    public class igGuiFilmStrip : igGuiSprite
    {
        [FieldAttr(nst: 64, ctr: 60)] public float _rows = 1.0f;
        [FieldAttr(nst: 68, ctr: 64)] public float _columns = 1.0f;
        [FieldAttr(nst: 72, ctr: 68)] public float _fps = 30.0f;
        [FieldAttr(nst: 76, ctr: 72)] public EigGuiAnimationLoopMode _loopMode;
        [FieldAttr(nst: 80, ctr: 76)] public float _frame;
        [FieldAttr(nst: 84, ctr: 80)] public float _velocity = 1.0f;
    }
}
