using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptFundo : MonoBehaviour
{
    private Rigidbody2D rbd;
    private float altura;
    // Start is called before the first frame update
    void Start()
    {
        altura = Camera.main.orthographicSize;

        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -3);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < (-2 * altura))
            transform.position = new Vector2(transform.position.x, altura + altura/2);
    }
}
