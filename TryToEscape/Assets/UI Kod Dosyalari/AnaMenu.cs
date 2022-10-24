using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AnaMenu : MonoBehaviour
{

    public void OyunuKapat()
    {
        Application.Quit();
    }
    public void Seviye1Basla(string sahne)
    {
        SceneManager.LoadScene(sahne);
    }
}
