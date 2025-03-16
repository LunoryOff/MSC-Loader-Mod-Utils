using HutongGames.PlayMaker;
using UnityEngine;

namespace ModUtils.Drivable
{
   
    public class MoveDownInCar : MonoBehaviour
    {
        protected GameObject player;
        protected FsmBool playerincarfsm;

        private void Start()
        {
            player = GameObject.Find("PLAYER");
            PlayMakerFSM[] fsms = player.GetComponents<PlayMakerFSM>();

            if (fsms.Length > 1)
            {
                playerincarfsm = fsms[1].FsmVariables.FindFsmBool("PlayerInCar");
            }
        }
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "PLAYER")
            {
                playerincarfsm.Value = true;
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.gameObject.name == "PLAYER")
            {
                playerincarfsm.Value = false;
            }
        }
    }
}
