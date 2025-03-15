using UnityEngine;

namespace ModUtils.Drivable
{
    
    public class MoveDownInCar : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "PLAYER")
            {
                other.gameObject.GetComponents<PlayMakerFSM>()[1].FsmVariables.GetFsmBool("PlayerInCar").Value = true;
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.gameObject.name == "PLAYER")
            {
                other.gameObject.GetComponents<PlayMakerFSM>()[1].FsmVariables.GetFsmBool("PlayerInCar").Value = false;
            }
        }
    }
}