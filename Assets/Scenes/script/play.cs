using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    //public GameObject anim;
    public void PlayGame()
    {
       // anim.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Options()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    // Start is called before the first frame update
    void Start()
    {
       // anim.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
