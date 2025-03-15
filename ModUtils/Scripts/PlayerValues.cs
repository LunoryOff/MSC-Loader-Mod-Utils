using HutongGames.PlayMaker;

namespace ModUtils
{
    public class PlayerValues
    {
        private static readonly string[] Values = new string[23]
        {
            // float
            "PlayerStress",
            "PlayerFatigue",
            "PlayerFatigueRate",
            "PlayerHunger",
            "PlayerThirst",
            "PlayerDrunk",
            "PlayerMoney",
            "PlayerUrine",
            "PlayerDirtiness",
            "PlayerWeight",
            // int
            "PlayerСigarettes",
            "PlayerKeyFerndale",
            "PlayerKeyGifu",
            "PlayerKeyHayosiko",
            "PlayerKeyHome",
            "PlayerKeySatsuma",
            "PlayerKeyRuscko",
            // string
            "PlayerCurrentVehicle",
            "GUIinteraction",
            "GUIsubtitle",
            "GUIgear",
            // bool
            "PlayerStop",
            "PlayerSeated"
        };

        public static float Stress
        {
            get => Framework_Float(Values[0]).Value;
            set => Framework_Float(Values[0]).Value = value;
        }

        public static float Fatigue
        {
            get => Framework_Float(Values[1]).Value;
            set => Framework_Float(Values[1]).Value = value;
        }

        public static float FatigueRate
        {
            get => Framework_Float(Values[2]).Value;
            set => Framework_Float(Values[2]).Value = value;
        }

        public static float Hunger
        {
            get => Framework_Float(Values[3]).Value;
            set => Framework_Float(Values[3]).Value = value;
        }

        public static float Thirst
        {
            get => Framework_Float(Values[4]).Value;
            set => Framework_Float(Values[4]).Value = value;
        }

        public static float DrunkEffect
        {
            get => Framework_Float(Values[5]).Value;
            set => Framework_Float(Values[5]).Value = value;
        }

        public static float Money
        {
            get => Framework_Float(Values[6]).Value;
            set => Framework_Float(Values[6]).Value = value;
        }

        public static float Urine
        {
            get => Framework_Float(Values[7]).Value;
            set => Framework_Float(Values[7]).Value = value;
        }

        public static float Dirtiness
        {
            get => Framework_Float(Values[8]).Value;
            set => Framework_Float(Values[8]).Value = value;
        }

        public static float Weight
        {
            get => Framework_Float(Values[9]).Value;
            set => Framework_Float(Values[9]).Value = value;
        }

        public static int CurrentСigarettes
        {
            get => Framework_Int(Values[10]).Value;
            set => Framework_Int(Values[10]).Value = value;
        }

        public static int KeyFerndale
        {
            get => Framework_Int(Values[11]).Value;
            set => Framework_Int(Values[11]).Value = value;
        }

        public static int KeyGifu
        {
            get => Framework_Int(Values[12]).Value;
            set => Framework_Int(Values[12]).Value = value;
        }

        public static int KeyHayosiko
        {
            get => Framework_Int(Values[13]).Value;
            set => Framework_Int(Values[13]).Value = value;
        }

        public static int KeyHome
        {
            get => Framework_Int(Values[14]).Value;
            set => Framework_Int(Values[14]).Value = value;
        }

        public static int KeySatsuma
        {
            get => Framework_Int(Values[15]).Value;
            set => Framework_Int(Values[15]).Value = value;
        }

        public static int KeyRuscko
        {
            get => Framework_Int(Values[16]).Value;
            set => Framework_Int(Values[16]).Value = value;
        }

        public static string CurrentVehicle
        {
            get => Framework_String(Values[17]).Value;
            set => Framework_String(Values[17]).Value = value;
        }

        public static string GUIinteraction
        {
            get => Framework_String(Values[18]).Value;
            set => Framework_String(Values[18]).Value = value;
        }

        public static string GUIsubtitle
        {
            get => Framework_String(Values[19]).Value;
            set => Framework_String(Values[19]).Value = value;
        }

        public static string GUIGear
        {
            get => Framework_String(Values[20]).Value;
            set => Framework_String(Values[20]).Value = value;
        }

        public static bool PlayerStop
        {
            get => Framework_Bool(Values[21]).Value;
            set => Framework_Bool(Values[21]).Value = value;
        }

        public static bool Seat
        {
            get => Framework_Bool(Values[22]).Value;
            set => Framework_Bool(Values[22]).Value = value;
        }

        private static FsmInt Framework_Int(string str) => FsmVariables.GlobalVariables.FindFsmInt(str);
        private static FsmFloat Framework_Float(string str) => FsmVariables.GlobalVariables.FindFsmFloat(str);
        private static FsmBool Framework_Bool(string str) => FsmVariables.GlobalVariables.FindFsmBool(str);
        private static FsmString Framework_String(string str) => FsmVariables.GlobalVariables.FindFsmString(str);
    }
}