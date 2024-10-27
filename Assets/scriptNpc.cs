using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptNpc : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel = 5;
    private float altura;
    private float largura;
    private AudioSource som;


    // Start is called before the first frame update
    void Start()
    {
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;

        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -vel);

        som = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -altura)
        {
            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D col) {
        //som.Play();
        
        Destroy(col.gameObject);
        Destroy(gameObject);
        // Destroy(gameObject,0.5f); //melhorar
        
    }
}
