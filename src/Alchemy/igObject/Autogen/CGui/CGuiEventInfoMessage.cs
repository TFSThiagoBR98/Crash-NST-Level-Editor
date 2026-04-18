namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CGuiEventInfoMessage : igGuiEvent
    {
        public enum EInfoMessageState
        {
            eIMS_None = 0,
            eIMS_Loading = 1,
            eIMS_SkipAttempt = 2,
            eIMS_SkipWait = 3,
            eIMS_Paused = 4,
        }

        [FieldAttr(nst: 24)] public EInfoMessageState _state;
    }
}
