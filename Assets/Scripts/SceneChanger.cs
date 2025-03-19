using UnityEngine;
using UnityEngine.SceneManagement;  // SceneManager'� kullanabilmek i�in gerekli

public class SceneChanger : MonoBehaviour
{
    // Butona bas�l�nca �al��acak fonksiyon

    public void ChangeScene0()
    {
        // 1 numaral� sahneye ge�i� yap
        SceneManager.LoadScene(0);
    }

    public void ChangeScene1()
    {
        // 1 numaral� sahneye ge�i� yap
        SceneManager.LoadScene(1);
    }

    public void ChangeScene2()
    {
        // 1 numaral� sahneye ge�i� yap
        SceneManager.LoadScene(2);
    }

    public void ChangeScene3()
    {
        // 1 numaral� sahneye ge�i� yap
        SceneManager.LoadScene(3);
    }

    public void ExitGame()
    {
        // Oyunu kapat
        Application.Quit();
    }
}
