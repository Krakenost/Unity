using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angka : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int Max = 1000; //integer digunakan untuk menyimpan nilai dengan tipe data decimal tanpa koma
        float TinggiBadan = 1.7f; //float digunakan untuk menyimpan nilai decimal yang berkoma dan juga yang tidak
        bool Hidup = true; //boolean suatu tipe data yang hanya memiliki dua kemungkinan yaitu "true/false (0/1)
        string Nama = "Krakenost"; //string tipe data yang digunakan untuk menyinpan karakter
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
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Tombol Panah Bawah Telah Ditekan");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Tombol Enter Telah Ditekan");
        }
    }
}
