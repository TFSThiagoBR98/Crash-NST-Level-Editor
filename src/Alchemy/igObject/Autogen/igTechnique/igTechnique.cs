namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class igTechnique : igNamedObject
    {
        [FieldAttr(nst: 24)] public igCachedAttrList? _attrs;
        [FieldAttr(nst: 32)] public igTechniqueParameterList? _parameterList;
        [FieldAttr(nst: 40)] public igTechniqueSamplerList? _samplerList;
        [FieldAttr(nst: 48)] public igTechniqueVertexComponentList? _vertexComponents;
        [FieldAttr(nst: 56)] public int _appFlags;
    }
}
