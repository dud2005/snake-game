using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenetransition : MonoBehaviour
{

    public Animator transitionsnim;
    // public string sceneName;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

  //  IEnumerator LoadScene()
  //  {
     //   transitionsnim.SetTrigger("play end");
     //   yield return new WaitForSeconds(1.5f);
     //   
  //  }
}
