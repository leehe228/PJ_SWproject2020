using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;

public class Basic_Steps : MonoBehaviour {

    public GameObject L_RedLight;
    public GameObject L_YellowLight;
    public GameObject L_GreenLight;

    public GameObject R_RedLight;
    public GameObject R_YellowLight;
    public GameObject R_GreenLight;

    public GameObject U_RedLight;
    public GameObject U_YellowLight;
    public GameObject U_GreenLight;

    public GameObject D_RedLight;
    public GameObject D_YellowLight;
    public GameObject D_GreenLight;

    public int step;

    static int CHANGE_LIGHT_TERM = 5;

    /*
     * STEP
     * -1 : L, R Green / U, D Red
     * 0 : All Yellow
     * 1 : L, R Red / U, D Green
     */

    void Start() {
        step = 1;

        L_RedLight.SetActive(true); ;
        L_YellowLight.SetActive(false);
        L_GreenLight.SetActive(false);

        R_RedLight.SetActive(true); ;
        R_YellowLight.SetActive(false);
        R_GreenLight.SetActive(false);

        U_RedLight.SetActive(false);
        U_YellowLight.SetActive(false);
        U_GreenLight.SetActive(true);

        D_RedLight.SetActive(false);
        D_YellowLight.SetActive(false);
        D_GreenLight.SetActive(true);

        InvokeRepeating("ChangeLight", CHANGE_LIGHT_TERM, CHANGE_LIGHT_TERM);
    }

    void Update() {
        /*if (Input.GetMouseButtonDown(0)) {
            ChangeLight();
        }*/
    }

    void ChangeLight() {
        if(step == 1) {
            step = 0;
            YellowLight();
            Invoke("turnLR", 1);
        }

        else if(step == -1) {
            step = 0;
            YellowLight();
            Invoke("turnUD", 1);
        }
    }

    void YellowLight() {
        L_RedLight.SetActive(false);
        L_YellowLight.SetActive(true);
        L_GreenLight.SetActive(false);

        R_RedLight.SetActive(false);
        R_YellowLight.SetActive(true);
        R_GreenLight.SetActive(false);

        U_RedLight.SetActive(false);
        U_YellowLight.SetActive(true);
        U_GreenLight.SetActive(false);

        D_RedLight.SetActive(false);
        D_YellowLight.SetActive(true);
        D_GreenLight.SetActive(false);
    }

    void turnLR() {
        L_RedLight.SetActive(false); ;
        L_YellowLight.SetActive(false);
        L_GreenLight.SetActive(true);

        R_RedLight.SetActive(false); ;
        R_YellowLight.SetActive(false);
        R_GreenLight.SetActive(true);

        U_RedLight.SetActive(true);
        U_YellowLight.SetActive(false);
        U_GreenLight.SetActive(false);

        D_RedLight.SetActive(true);
        D_YellowLight.SetActive(false);
        D_GreenLight.SetActive(false);
        step = -1;
    }

    void turnUD() {
        L_RedLight.SetActive(true); ;
        L_YellowLight.SetActive(false);
        L_GreenLight.SetActive(false);

        R_RedLight.SetActive(true); ;
        R_YellowLight.SetActive(false);
        R_GreenLight.SetActive(false);

        U_RedLight.SetActive(false);
        U_YellowLight.SetActive(false);
        U_GreenLight.SetActive(true);

        D_RedLight.SetActive(false);
        D_YellowLight.SetActive(false);
        D_GreenLight.SetActive(true);
        step = 1;
    }
}
