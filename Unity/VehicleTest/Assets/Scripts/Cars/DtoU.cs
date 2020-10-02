using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DtoU : MonoBehaviour
{
    private static int Speed = 2;
    public Basic_Steps trafficLight;
    private Vector3 pos;

    private bool colCheck;

    void Start() {
        trafficLight = GameObject.Find("ControlLights").GetComponent<Basic_Steps>();
        colCheck = false;
    }

    void Update() {
        pos = transform.position;

        if (trafficLight.step != 1)
        {
            if ((-0.99 >= pos.y && pos.y >= -1.2) || colCheck == true)
            {
                if (-0.99 >= pos.y)
                {
                    transform.Translate(Vector2.zero);
                }
                else
                {
                    transform.Translate(Vector2.up * Speed * Time.deltaTime);
                }

            }
            else
            {
                transform.Translate(Vector2.up * Speed * Time.deltaTime);
            }
        }
        else
        {
            transform.Translate(Vector2.up * Speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        colCheck = true;
    }

    void OnTriggerStay2D(Collider2D col)
    {

    }

    void OnTriggerExit2D(Collider2D col)
    {
        colCheck = false;
    }
}
