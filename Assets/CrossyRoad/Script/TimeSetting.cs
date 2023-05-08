using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeSetting : MonoBehaviour
{
    public float waktuPerbaruan;

    private int nilaiSaatIni;
    private float waktuTerakhirPerbaruan;
    [SerializeField] private float lastTime;
    [SerializeField] private TextMeshProUGUI lastHitungan;
    [SerializeField] TextMeshProUGUI teksHitunganMaju;

    void Start()
    {
        nilaiSaatIni = 0;
        waktuTerakhirPerbaruan = Time.time;
    }

    void Update()
    {
        lastTime = nilaiSaatIni;
        lastHitungan.text = lastTime.ToString();
        if (!GameManager.isGameOver)
        {
            if (Time.time - waktuTerakhirPerbaruan > waktuPerbaruan )
            {
                nilaiSaatIni++;
                teksHitunganMaju.text = nilaiSaatIni.ToString();
                waktuTerakhirPerbaruan = Time.time;
            }
        }
    }
    
}
