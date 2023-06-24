using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloHello : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log("Scripting change");
        rend = GetComponent<Renderer>();

        StartCoroutine(ChangeColor());
    }

    public List<Color> colors = new List<Color>() {Color.red, Color.green, Color.blue};
    private WaitForSeconds wait1s = new WaitForSeconds(1f);

    private IEnumerator ChangeColor()
    {
        int color = 0;
        while(true)
        {
            if(color >= colors.Count)
            {
                color = 0;
            }

            rend.material.SetColor("_Color", colors[color]);
            color++;

            yield return wait1s;
        }
    }
}
