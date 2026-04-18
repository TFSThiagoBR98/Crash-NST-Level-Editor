namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CVehicleTutorialComponentData : CEntityComponentData
    {
        public enum EVehicleTutorialType
        {
            eVTT_None = 0,
            eVTT_Sea = 1,
            eVTT_Air = 2,
            eVTT_Coop = 3,
        }

        [FieldAttr(nst: 24)] public EVehicleTutorialType _tutorialType;
        [FieldAttr(nst: 32)] public igHandleMetaField _pauseMenuFocusedOptionOverride = new();
    }
}
