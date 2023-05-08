using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] private GameObject image1;
    [SerializeField] private GameObject image2;
    [SerializeField] private GameObject image3;

    [SerializeField] private Button[] PapperRock;

    private bool nunggu3selesaiBoos;
    
    void Start()
    {
        image1.SetActive(false);
        image2.SetActive(false);
        image3.SetActive(false);
        Invoke("ShowImage1",0.5f);
        Invoke("ShowImage2",4f);
        Invoke("ShowImage3",6f);
        Invoke("selesai",8f);
        
    }

    private void Update()
    {
        if (image3.active && nunggu3selesaiBoos)
        {
            image1.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(false);
            
            foreach (Button button in PapperRock)
            {
                button.interactable = true;
            }
                
        }
    }

    void ShowImage1()
    {
        image1.SetActive(true);
    }
    
    void ShowImage2()
    {
        image2.SetActive(true);
    }
    
    void ShowImage3()
    {
        image3.SetActive(true);
    }

    void selesai()
    {
        nunggu3selesaiBoos = true;
    }
    
}