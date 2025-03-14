using HutongGames.PlayMaker;

namespace ModUtils
{
    public static class GUIStates
    {
        public static FsmBool Use = FsmVariables.GlobalVariables.FindFsmBool("GUIuse");
        public static FsmBool Assemble = FsmVariables.GlobalVariables.FindFsmBool("GUIassemble");
        public static FsmBool Disassemble = FsmVariables.GlobalVariables.FindFsmBool("GUIdisassemble");
        public static FsmBool Buy = FsmVariables.GlobalVariables.FindFsmBool("GUIbuy");
        public static FsmBool Drive = FsmVariables.GlobalVariables.FindFsmBool("GUIdrive");
        public static FsmBool PassengerSeat = FsmVariables.GlobalVariables.FindFsmBool("GUIpassenger");
        public static FsmString InteractionText = FsmVariables.GlobalVariables.FindFsmString("GUIinteraction");
        public static FsmString SubtitleText = FsmVariables.GlobalVariables.FindFsmString("GUIsubtitle");
    }
}
