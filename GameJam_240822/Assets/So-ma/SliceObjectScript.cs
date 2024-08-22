using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SliceObjectScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(Random.Range(-3f, 3f), Random.Range(2f, 4f)), ForceMode2D.Impulse);
        StartCoroutine(DestroyObject());
    }

    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(3f);
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
