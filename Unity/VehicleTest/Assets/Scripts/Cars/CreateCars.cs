using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class CreateCars : MonoBehaviour {

    public GameObject RtoL;
    public GameObject LtoR;
    public GameObject UtoD;
    public GameObject DtoU;

    public Basic_Steps trafficLight;

    private System.Random random;

    static int SPAWN_CAR_DELAY = 1;

    // Start is called before the first frame update
    void Start() {
        InvokeRepeating("SpawnCars", SPAWN_CAR_DELAY, SPAWN_CAR_DELAY);
        trafficLight = GameObject.Find("ControlLights").GetComponent<Basic_Steps>();
        random = new System.Random();
    }

    // Update is called once per frame
    void Update() {
        
    }

    void SpawnCars() {
        int i = random.Next() % 3;
        int j = random.Next() % 3;
        int z = random.Next() % 3;
        int k = random.Next() % 3;

        Instantiate(RtoL, new Vector2(9.5f, 0.15f + i * 0.33f), Quaternion.identity);
        Instantiate(LtoR, new Vector2(-9.5f, -0.15f - j * 0.33f), Quaternion.identity);
        Instantiate(UtoD, new Vector2(-0.15f - k * 0.33f, 5.5f), Quaternion.identity);
        Instantiate(DtoU, new Vector2(0.15f + z * 0.33f, -5.5f), Quaternion.identity);
    }
}
