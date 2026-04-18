namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class igCinematicAnimationInstance : igObject
    {
        [FieldAttr(ctr: 12)] public float _time;
        [FieldAttr(ctr: 16)] public float _endTime;
        [FieldAttr(ctr: 20)] public float _speed;
        [FieldAttr(ctr: 24)] public JuiceScene? _scene;
        [FieldAttr(ctr: 32)] public JuiceAnimation? _animation;
        [FieldAttr(ctr: 40)] public bool _isStale;
    }
}
