using System;
using UnityEngine;
using UnityEngine.UI;
public class Vida : MonoBehaviour
{
    public Slider slidevida;
    public int vida;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        slidevida.value = vida;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            vida = vida - 20;
        }
    }
}
