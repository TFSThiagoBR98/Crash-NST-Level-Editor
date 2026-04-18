namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class igEffect : igNamedObject
    {
        [FieldAttr(nst: 24)] public igTechniqueList? _techniqueList;
        [FieldAttr(nst: 32)] public igObjectAnnotationTable? _annotations;
        [FieldAttr(nst: 40)] public igIntList? _globalTechniqueList;
        [FieldAttr(nst: 48)] public u64 _globalTechniqueMask;
    }
}
