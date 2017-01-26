using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bird : MonoBehaviour
{
    private Transform EggHolder;
    public GameObject EggType;

    public float EggSize;

    public float DropInterval;
    private float TimeOfLastDrop;

	void Start ()
    {
        EggHolder = new GameObject("Egg Holder").transform;
        EggHolder.parent = GetComponent<Transform>();

        TimeOfLastDrop = Time.time;
	}
	
	void Update ()
    {
		if (Time.time - TimeOfLastDrop >= DropInterval)
        {
            GameObject instance = Instantiate(EggType, GetComponent<Transform>().position, Quaternion.identity);
            instance.transform.parent = EggHolder;
            instance.transform.localScale *= EggSize;

            TimeOfLastDrop = Time.time;
        }
	}
}
