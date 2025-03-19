using UnityEngine;
using UnityEngine.SceneManagement;  // SceneManager'ý kullanabilmek için gerekli

public class SceneChanger : MonoBehaviour
{
    // Butona basýlýnca çalýþacak fonksiyon

    public void ChangeScene0()
    {
        // 1 numaralý sahneye geçiþ yap
        SceneManager.LoadScene(0);
    }

    public void ChangeScene1()
    {
        // 1 numaralý sahneye geçiþ yap
        SceneManager.LoadScene(1);
    }

    public void ChangeScene2()
    {
        // 1 numaralý sahneye geçiþ yap
        SceneManager.LoadScene(2);
    }

    public void ChangeScene3()
    {
        // 1 numaralý sahneye geçiþ yap
        SceneManager.LoadScene(3);
    }

    public void ExitGame()
    {
        // Oyunu kapat
        Application.Quit();
    }
}
