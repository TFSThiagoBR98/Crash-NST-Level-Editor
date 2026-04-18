namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CutsceneActionPlayCamera : CCutsceneAction
    {
        [FieldAttr(nst: 24, ctr: 24)] public CCutsceneCamera? _camera;
        [FieldAttr(nst: 32, ctr: 32)] public int _shotNumber;
        [FieldAttr(nst: 36, ctr: 36)] public float _shotStartTime;
        [FieldAttr(nst: 40, ctr: 40)] public float _shotDuration;
    }
}
