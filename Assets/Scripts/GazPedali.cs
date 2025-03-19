using UnityEngine;

public class GazPedali : MonoBehaviour
{
    public AudioSource motorSes;  // Ses kaynaðýný buraya baðla
    public float sesVolumu = 1f;  // Sesin yoðunluðunu ayarlamak için

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))  // Gaz pedalýna basmak için örnek: 'W' tuþu
        {
            if (!motorSes.isPlaying)  // Eðer ses çalmýyorsa
            {
                motorSes.Play();  // Sesi baþlat
            }

            motorSes.volume = Mathf.Lerp(0f, sesVolumu, Time.time);  // Sesin artmasý için
        }
        else
        {
            if (motorSes.isPlaying)  // Gaz býrakýldýðýnda ses duracak
            {
                motorSes.Stop();
            }
        }
    }
}
