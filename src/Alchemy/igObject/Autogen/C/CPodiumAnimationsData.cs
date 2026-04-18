namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CPodiumAnimationsData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _podiumAnimationNameIntro;
        [FieldAttr(ctr: 24)] public string? _podiumAnimationNameLoop;
        [FieldAttr(ctr: 32)] public CCutsceneCamera? _podiumCamera;
    }
}
