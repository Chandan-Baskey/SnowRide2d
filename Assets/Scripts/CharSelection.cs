using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharSelection : MonoBehaviour
{
    [SerializeField] GameObject scoreCanvas;
    [SerializeField] GameObject Srak;
    [SerializeField] GameObject Chita;
    [SerializeField] GameObject Wolf;
    void Start()
    {
        Time.timeScale = 0;
    }

    void BeginGame()
    {
        Time.timeScale = 1f;
        scoreCanvas.SetActive(true);
        gameObject.SetActive(false);
    }
      
    public void ChooseSrak()
    {
        Srak.SetActive(true);
        BeginGame();
    }
    public void ChooseChita()
    {
        Chita.SetActive(true);
        BeginGame();
    }
    public void ChooseWolf()
    {
        Wolf.SetActive(true);
        BeginGame();
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }

}
