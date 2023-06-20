using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    // public GameObject prefab;
    public GameObject canvas;
    public GameObject food;
    public GameObject buttom;
    public AudioSource audio;
    private void Start()
    {
        canvas.SetActive(false);
        food.SetActive(true);
        buttom.SetActive(false);
        
    }
    public void Update()
    {
       
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            audio.Play();
            canvas.SetActive(true);
            food.SetActive(false);
            buttom.SetActive(true);
        }
    }
}




