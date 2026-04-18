namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class CCameraTargetComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public bool _isHero;
        [FieldAttr(nst: 25, ctr: 17)] public bool _disablePlayerTargetsWhileEnabled;
        [FieldAttr(nst: 26, ctr: 18)] public bool _zoomToFit;
        [FieldAttr(nst: 28, ctr: 20)] public float _dampingFactor = 0.2f;
        [FieldAttr(nst: 32, ctr: 24)] public float _weight = 0.6f;
        [FieldAttr(nst: 36, ctr: 28)] public float _innerRadius = 300.0f;
        [FieldAttr(nst: 40, ctr: 32)] public float _outerRadius = 800.0f;
        [FieldAttr(nst: 44, ctr: 36)] public float _enableRadius = 1200.0f;
        [FieldAttr(nst: 48, ctr: 40)] public float _disableRadius = 1300.0f;
        [FieldAttr(nst: 52, ctr: 44)] public float _blendInTime = 1.5f;
        [FieldAttr(nst: 56, ctr: 48)] public bool _skipBlendInTimeOnFirstEnable;
        [FieldAttr(nst: 60, ctr: 52)] public float _blendOutTime = 1.5f;
        [FieldAttr(nst: 64, ctr: 56)] public bool _startEnabled = true;
        [FieldAttr(nst: 68, ctr: 60)] public float _autoDisableTime = -1.0f;
        [FieldAttr(nst: 72, ctr: 64)] public float _heightOffset = 45.0f;
    }
}
