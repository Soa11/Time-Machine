using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stainColourChange : MonoBehaviour
{


    public Renderer rend;
    public float timeLeft;
    public Color targetColor;
    public Color currentColor;


    // Start is called before the first frame update
    void Start()
    {
      
        rend = GetComponent<Renderer>();
        //rend.material.shader = Shader.Find("HDRenderPipeline/Lit");
        //rend.material.SetColor("_BaseColor", targetColor);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft <= Time.deltaTime)
        {
            // transition complete
            // assign the target color

            //rend.material.SetColor("_BaseColor", currentColor);
            

            // start a new transition
            targetColor = new Color(Random.value, Random.value, Random.value, 0.85f);
            timeLeft = 5f;
        }
        else
        {
            // transition in progress
            // calculate interpolated color


            currentColor = rend.material.color; 
           
            rend.material.color = Color.Lerp(currentColor, targetColor, Time.deltaTime / timeLeft);
            rend.material.SetColor("_BaseColor", currentColor);
            // update the timer
            timeLeft -= Time.deltaTime;
        }
    }
}

