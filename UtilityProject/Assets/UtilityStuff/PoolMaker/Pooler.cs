using System.Collections.Generic;
using Unity;
using UnityEngine;

public class Pooler : MonoBehaviour {

    public static List<T> GetPoolObjects<T> (T prefab, int numberList, GameObject pool) where T : Component {

        List<T> poolList = new List<T> ();

        for (int i = 0; i < numberList; i++) {
            T instance = Instantiate (prefab);
            instance.transform.parent = pool.transform;
            instance.gameObject.SetActive (false);
            poolList.Add (instance as T);
        }

        return poolList;

    }

    public static List<GameObject> GetPoolObjects (GameObject prefab, int numberList, GameObject pool) {
        List<GameObject> poolList = new List<GameObject> ();

        for (int i = 0; i < numberList; i++) {
            GameObject instance = Instantiate (prefab);
            instance.transform.parent = pool.transform;
            instance.gameObject.SetActive (false);
            poolList.Add (instance as GameObject);
        }

        return poolList;
    }
}