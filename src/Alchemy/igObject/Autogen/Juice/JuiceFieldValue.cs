namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class JuiceFieldValue : igObject
    {
        [FieldAttr(ctr: 16)] public igCinematicObject? _object;
        [FieldAttr(ctr: 24)] public igFloatMetaFieldInstance? _field;
        [FieldAttr(ctr: 32)] public float _value;
    }
}
