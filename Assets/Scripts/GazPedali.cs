using UnityEngine;

public class GazPedali : MonoBehaviour
{
    public AudioSource motorSes;  // Ses kayna��n� buraya ba�la
    public float sesVolumu = 1f;  // Sesin yo�unlu�unu ayarlamak i�in

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))  // Gaz pedal�na basmak i�in �rnek: 'W' tu�u
        {
            if (!motorSes.isPlaying)  // E�er ses �alm�yorsa
            {
                motorSes.Play();  // Sesi ba�lat
            }

            motorSes.volume = Mathf.Lerp(0f, sesVolumu, Time.time);  // Sesin artmas� i�in
        }
        else
        {
            if (motorSes.isPlaying)  // Gaz b�rak�ld���nda ses duracak
            {
                motorSes.Stop();
            }
        }
    }
}
