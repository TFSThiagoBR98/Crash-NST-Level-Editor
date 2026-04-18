namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CRacerLOD : igObject
    {
        [FieldAttr(ctr: 16)] public string? _lodFile;
        [FieldAttr(ctr: 24)] public string? _lodFileConverted;
    }
}
