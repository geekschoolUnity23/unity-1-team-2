using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleScript : MonoBehaviour
{
    public GameObject gameOb;
    // Update is called once per frame
    void Update()
    {
        float lSX = gameOb.transform.localScale.x;
        if (Input.GetKey(KeyCode.Q))
        {
            gameOb.transform.localScale = new Vector3(lSX + 0.5f, lSX + 0.5f, lSX + 0.5f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            gameOb.transform.localScale = new Vector3(lSX - 0.5f, lSX - 0.5f, lSX - 0.5f);
        }
    }
}
