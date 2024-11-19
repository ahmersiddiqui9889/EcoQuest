using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public bool fadein = false;
    public bool fadeout = false;
    public float timeToFade;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fadein == true) {
            if(canvasGroup.alpha < 1) {
                canvasGroup.alpha += timeToFade * Time.deltaTime;
                if(canvasGroup.alpha >= 1) {
                    fadein = false;
                }
            }
        }
        if(fadeout == true) {
            if(canvasGroup.alpha >= 0) {
                canvasGroup.alpha -= timeToFade * Time.deltaTime;
                if(canvasGroup.alpha == 0) {
                    fadeout = false;
                }
            }
        }
        
    }
    public void FadeIn()
    {
        fadein = true;
    }

    public void FadeOut()
    {
        fadeout = true;
    }
}
