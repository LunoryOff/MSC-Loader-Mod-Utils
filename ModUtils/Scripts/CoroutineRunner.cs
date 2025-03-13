using UnityEngine;

namespace ModUtils
{
    public static class CoroutineRunner
    {
        public static CoroutineRunnerComponent coroutineRunner;

        public static void Init()
        {
            if (coroutineRunner == null)
            {
                GameObject obj = new GameObject("CoroutineRunner");
                coroutineRunner = obj.AddComponent<CoroutineRunnerComponent>();
                Object.DontDestroyOnLoad(obj);
            }
        }
    }
}
