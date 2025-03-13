using System.Collections.Generic;
using UnityEngine;

namespace ModUtils
{
    public class ObjectPool<T> where T : Object
    {
        private T prefab;
        private Transform parent;
        private Queue<T> pool = new Queue<T>();

        public ObjectPool(T prefab, int initialSize, Transform parent = null)
        {
            this.prefab = prefab;
            this.parent = parent;

            for (int i = 0; i < initialSize; i++)
            {
                T obj = CreateNewObject();
                AddToPool(obj);
            }
        }

        private T CreateNewObject()
        {
            if (prefab is Component componentPrefab)
            {
                Component newObj = Object.Instantiate(
                    componentPrefab,
                    parent ? parent.position : Vector3.zero,
                    Quaternion.identity
                ) as Component;

                if (parent != null)
                {
                    newObj.transform.SetParent(parent);
                }

                return newObj as T;
            }
            else if (prefab is GameObject gameObjPrefab)
            {
                GameObject newObj = Object.Instantiate(
                    gameObjPrefab,
                    parent ? parent.position : Vector3.zero,
                    Quaternion.identity
                ) as GameObject;

                if (parent != null)
                {
                    newObj.transform.SetParent(parent);
                }

                return newObj as T;
            }

            throw new System.InvalidOperationException("Unsupported type for ObjectPool");
        }

        private void AddToPool(T obj)
        {
            if (obj is Component component)
            {
                component.gameObject.SetActive(false);
            }
            else if (obj is GameObject gameObj)
            {
                gameObj.SetActive(false);
            }
            pool.Enqueue(obj);
        }

        public T GetObject()
        {
            if (pool.Count == 0)
            {
                T newObj = CreateNewObject();
                AddToPool(newObj);
            }

            T obj = pool.Dequeue();

            if (obj is Component component)
            {
                component.gameObject.SetActive(true);
            }
            else if (obj is GameObject gameObj)
            {
                gameObj.SetActive(true);
            }

            return obj;
        }

        public void ReturnObject(T obj)
        {
            if (obj == null) return;

            if (obj is Component component && component.gameObject != null)
            {
                component.gameObject.SetActive(false);
            }
            else if (obj is GameObject gameObj)
            {
                gameObj.SetActive(false);
            }

            if (parent != null)
            {
                if (obj is Component c) c.transform.SetParent(parent);
                else if (obj is GameObject go) go.transform.SetParent(parent);
            }

            pool.Enqueue(obj);
        }
    }
}