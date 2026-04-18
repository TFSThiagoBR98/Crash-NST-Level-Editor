namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CDisableForCutsceneComponentData : igComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public EDisableInCutsceneBehavior _disableMode;
        [FieldAttr(nst: 32, ctr: 24)] public igStringRefList? _cutsceneList;
    }
}
