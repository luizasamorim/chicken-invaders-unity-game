using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptRespawn : MonoBehaviour
{
    public GameObject inimigo;
    private float altura;
    private float largura;

    // Start is called before the first frame update
    void Start()
    {
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;

        InvokeRepeating("respawn", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void respawn()
    {
        float x = Random.Range(-largura, largura);
        Vector2 pos = new Vector2(x, altura);
        Instantiate(inimigo, pos, Quaternion.identity);
    }
}
