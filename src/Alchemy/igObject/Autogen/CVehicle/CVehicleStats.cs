namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 56, align: 4)]
    public class CVehicleStats : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public int _gripStat;
        [FieldAttr(nst: 20, ctr: 16)] public int _buoyancyStat;
        [FieldAttr(nst: 24, ctr: 20)] public int _hoverStat;
        [FieldAttr(nst: 28, ctr: 24)] public int _driftStat;
        [FieldAttr(nst: 32, ctr: 28)] public int _weightStat;
        [FieldAttr(nst: 36, ctr: 32)] public int _accelerationStat;
        [FieldAttr(nst: 40, ctr: 36)] public int _topSpeedStat;
        [FieldAttr(nst: 44, ctr: 40)] public int _shieldStat;
        [FieldAttr(nst: 48, ctr: 44)] public int _armorStat;
        [FieldAttr(nst: 52, ctr: 48)] public int _maneuverStat;
        [FieldAttr(nst: 56, ctr: 52)] public bool _dirty;
    }
}
