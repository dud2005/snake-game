using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{

    public GameObject canvas;
  //  public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        // canvas.SetActive(false);
     //   animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScene()
    {
       //  canvas.SetActive(true);

       
       // animator.Play("Base Layer.New Animation");      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

   
}
