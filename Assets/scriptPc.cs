using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPc : MonoBehaviour
{
    private Rigidbody2D rbd;
    private AudioSource som;
    public float vel;
    private float alturaTela;
    private float larguraTela;
    private float alturaNave;
    public GameObject tiro;

    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        vel = 10;

        alturaTela = Camera.main.orthographicSize;
        larguraTela = alturaTela * Camera.main.aspect;
        alturaNave = GetComponent<SpriteRenderer>().bounds.size.y /2;
        som = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rbd.velocity = new Vector2(x,y) * vel;

        if(transform.position.x > larguraTela)
            transform.position = new Vector2(-larguraTela, transform.position.y);
        else if(transform.position.x < -larguraTela)
            transform.position = new Vector2(larguraTela, transform.position.y);

        if(transform.position.y > 0)
            transform.position = new Vector2(transform.position.x, 0);
        else if(transform.position.y < (-alturaTela + alturaNave))
            transform.position = new Vector2(transform.position.x, (-alturaTela + alturaNave));
        
        //tiro
        if (Input.GetKeyDown("space"))
        {
            Vector2 pos = new Vector2(transform.position.x, transform.position.y);
            Instantiate(tiro, pos, Quaternion.identity);
            som.Play();
        }

    }
}
