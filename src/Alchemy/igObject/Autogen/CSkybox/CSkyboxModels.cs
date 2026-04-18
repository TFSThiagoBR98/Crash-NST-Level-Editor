namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CSkyboxModels : igObject
    {
        [FieldAttr(ctr: 16)] public CRigidModelInstance? _nearSkyModel;
        [FieldAttr(ctr: 24)] public CRigidModelInstance? _farSkyModel1;
        [FieldAttr(ctr: 32)] public CRigidModelInstance? _farSkyModel2;
        [FieldAttr(ctr: 40)] public CRigidModelInstance? _farSkyModel3;
        [FieldAttr(ctr: 48)] public CRigidModelInstance? _farSkyModel4;
    }
}
