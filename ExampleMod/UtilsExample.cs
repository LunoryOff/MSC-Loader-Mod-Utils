using MSCLoader;
using UnityEngine;
using ModUtils;
using System.Collections;

namespace UtilsExample
{
    public class UtilsExample : Mod
    {
        public override string ID => "UtilsExample";
        public override string Name => "Utils Example Mod";
        public override string Author => "Lunory";
        public override string Version => "1.0";

        private ReactiveValue<int> _score;
        private ObjectPool<GameObject> _objectPool;

        public override void ModSetup()
        {
            SetupFunction(Setup.OnMenuLoad, OnMenuLoad);
            SetupFunction(Setup.OnLoad, OnLoad);
        }

        void OnMenuLoad()
        {
            CoroutineRunner.Init();
            ConsoleTools.Log("ModUtils loaded!", 20, Color.cyan, true);
            
            // ReactiveValue Example
            _score = new ReactiveValue<int>();
            _score.ValueChanged += (val) => ConsoleTools.LogInfo($"Score changed: {val}");
            _score.Value = 100;

            // ObjectPool Example
            GameObject prefab = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _objectPool = new ObjectPool<GameObject>(prefab, 5);
            GameObject obj = _objectPool.GetObject();
            obj.transform.position = Vector3.zero;
        }

        void OnLoad()
        {
            // MeshReplacer Example
            MeshRenderer targetRenderer = GameObject.Find("someObject").GetComponent<MeshRenderer>();
            MeshFilter targetFilter = targetRenderer.GetComponent<MeshFilter>();
            Mesh newMesh = Resources.Load<Mesh>("CustomMesh");
            Material newMaterial = Resources.Load<Material>("CustomMaterial");
            MeshReplacer.ReplaceMesh(targetRenderer, targetFilter, newMesh, newMaterial);
        }

        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _score.Value += 10; // Trigger ValueChanged event
            }
        }
    }
}