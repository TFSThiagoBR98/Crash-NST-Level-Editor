namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CTTRData : igObject
    {
        [FieldAttr(ctr: 16)] public CLapTTRData? _positionTTR;
        [FieldAttr(ctr: 24)] public CLapTTRData? _rubberbandOffset;
    }
}
