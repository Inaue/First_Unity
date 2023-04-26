using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_P : MonoBehaviour
{
    public float ispid = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity    = Vector2.right * this.ispid;
    }

    float hitFactor(Vector2 bolaPos, Vector2 jogPos, float tam)
    {
	    return (bolaPos.y - jogPos.y)/tam;
    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.name == "coca_lef")
        {
            float y	= hitFactor(transform.position, colisao.transform.position, colisao.collider.bounds.size.y);

            Vector2 dir	= new Vector2(1,y).normalized;
            GetComponent<Rigidbody2D>().velocity	= dir*this.ispid;
        }

        if (colisao.gameObject.name == "coca_rig")
        {
            float y	= hitFactor(transform.position, colisao.transform.position, colisao.collider.bounds.size.y);

            Vector2 dir	= new Vector2(-1,y).normalized;
            GetComponent<Rigidbody2D>().velocity	= dir*this.ispid;
        }
	}
}
