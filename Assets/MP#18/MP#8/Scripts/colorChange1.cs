using UnityEngine;
using System.Collections;

public class colorChange1 : MonoBehaviour
{
    public Color  colorA= new Color(165,170,178,212);
    public Color colorB = new Color(52,71,246,153);
    private float timer = 0.0f;

    void Update()
    {

        timer += Time.deltaTime;

        gameObject.GetComponent<Renderer>().material.color = Color.Lerp(colorA, colorB, (Mathf.PingPong(timer/10,1)));




    }

}