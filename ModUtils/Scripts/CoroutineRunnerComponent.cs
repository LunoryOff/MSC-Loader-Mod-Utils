using UnityEngine;
using System.Collections;

namespace ModUtils
{
    public class CoroutineRunnerComponent : MonoBehaviour
    {
        public void StartCoroutineWrapper(IEnumerator coroutine)
        {
            StartCoroutine(coroutine);
        }
    }
}