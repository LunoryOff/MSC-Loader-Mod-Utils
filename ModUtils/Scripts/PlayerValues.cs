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
            
            set => Framework_Float(Values[0]).Value = value;
        }

        public static float Fatigue
        {
            
            set => Framework_Float(Values[1]).Value = value;
        }

        public static float FatigueRate
        {
            
            set => Framework_Float(Values[2]).Value = value;
        }

        public static float Hunger
        {
            
            set => Framework_Float(Values[3]).Value = value;
        }

        public static float Thirst
        {
            
            set => Framework_Float(Values[4]).Value = value;
        }

        public static float DrunkEffect
        {
            
            set => Framework_Float(Values[5]).Value = value;
        }

        public static float Money
        {
            
            set => Framework_Float(Values[6]).Value = value;
        }

        public static float Urine
        {
           
            set => Framework_Float(Values[7]).Value = value;
        }

        public static float Dirtiness
        {
           
            set => Framework_Float(Values[8]).Value = value;
        }

        public static float Weight
        {
            
            set => Framework_Float(Values[9]).Value = value;
        }

        public static int CurrentСigarettes
        {
            
            set => Framework_Int(Values[10]).Value = value;
        }

        public static int KeyFerndale
        {
            
            set => Framework_Int(Values[11]).Value = value;
        }

        public static int KeyGifu
        {
            
            set => Framework_Int(Values[12]).Value = value;
        }

        public static int KeyHayosiko
        {
            
            set => Framework_Int(Values[13]).Value = value;
        }

        public static int KeyHome
        {
            
            set => Framework_Int(Values[14]).Value = value;
        }

        public static int KeySatsuma
        {
            
            set => Framework_Int(Values[15]).Value = value;
        }

        public static int KeyRuscko
        {
            
            set => Framework_Int(Values[16]).Value = value;
        }

        public static string CurrentVehicle
        {
            
            set => Framework_String(Values[17]).Value = value;
        }

        public static string GUIinteraction
        {
            
            set => Framework_String(Values[18]).Value = value;
        }

        public static string GUIsubtitle
        {
            
            set => Framework_String(Values[19]).Value = value;
        }

        public static string GUIGear
        {
            
            set => Framework_String(Values[20]).Value = value;
        }

        public static bool PlayerStop
        {
            
            set => Framework_Bool(Values[21]).Value = value;
        }

        public static bool Seat
        {
            
            set => Framework_Bool(Values[22]).Value = value;
        }

        private static FsmInt Framework_Int(string str) => FsmVariables.GlobalVariables.FindFsmInt(str);
        private static FsmFloat Framework_Float(string str) => FsmVariables.GlobalVariables.FindFsmFloat(str);
        private static FsmBool Framework_Bool(string str) => FsmVariables.GlobalVariables.FindFsmBool(str);
        private static FsmString Framework_String(string str) => FsmVariables.GlobalVariables.FindFsmString(str);
    }
}
