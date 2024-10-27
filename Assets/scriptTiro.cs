using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTiro : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel = 7;
    private float altura;
    private float largura;

    // Start is called before the first frame update
    void Start()
    {
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;
        
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, vel);
    } 

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > altura)
        {
            Destroy(gameObject);
        }
    }
}
