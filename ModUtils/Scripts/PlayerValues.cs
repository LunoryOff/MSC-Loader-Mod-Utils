using HutongGames.PlayMaker;

namespace ModUtils
{
    public static class PlayerValues
    {
        public static FsmFloat Stress = FsmVariables.GlobalVariables.FindFsmFloat("PlayerStress");
        public static FsmFloat Fatigue = FsmVariables.GlobalVariables.FindFsmFloat("PlayerFatigue");
        public static FsmFloat Hunger = FsmVariables.GlobalVariables.FindFsmFloat("PlayerHunger");
        public static FsmFloat Thirst = FsmVariables.GlobalVariables.FindFsmFloat("PlayerThirst");
        public static FsmFloat DrunkEffect = FsmVariables.GlobalVariables.FindFsmFloat("PlayerDrunk");
        public static FsmFloat Money = FsmVariables.GlobalVariables.FindFsmFloat("PlayerMoney");
    }
}
