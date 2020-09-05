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
        Debug.Log("Pilih Angka 1 Sampai 1000!");
        Debug.Log("Nanti Angka Yang Kamu Pilih Akan Saya Tebak");
        Debug.Log("Tekan Tombol Atas Jika Tebakan Saya Terlalu Rendah!");
        Debug.Log("Tekan Tombol Bawah Jika Tebakan Saya Terlalu Tinggi!");
        Debug.Log("Tekan Tombol Enter Jika Tebakan Saya Benar!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Tombol Panah Atas Telah Ditekan");
            min = tebakan;
            Debug.Log(max);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Tombol Panah Bawah Telah Ditekan");
            max = tebakan;
            Debug.Log(min);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Tombol Enter Telah Ditekan");
            Debug.Log(tebakan);
        }
    }
}