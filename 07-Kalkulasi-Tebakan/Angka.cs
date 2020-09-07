using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angka : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int tebakan = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Selamat Datang Di Game Tebak Angka");
        Debug.Log("Pilihlah Angka " + min + " Sampai " + max);
        Debug.Log("Cara main: Tekan Atas, Tekan Bawah, Tekan Enter");
        Debug.Log("Atas Jika Tebakan Terlalu Rendah dan Tekan Bawah jika sebaliknya dan enter jika benar");
        Debug.Log("Apakah angka yang kamu pilih adalah " + tebakan) ;
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = tebakan;
            tebakan = (max + min) / 2;
            Debug.Log("Apakah angka yang kamu pilih adalah: " + tebakan);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = tebakan;
            tebakan = (max + min) / 2;
            Debug.Log("Apakah angka yang kamu pilih adalah: " + tebakan);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Ternyata angka yang kamu pilih adalah: " + tebakan);
        }
    }
}