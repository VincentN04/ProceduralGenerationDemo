using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    public GameObject gazon;

    // Start is called before the first frame update
    void Start()
    {
        // ThrowLine();
        for (int i = 0; i < 50; i++)
        {
            Debug.DrawRay(this.transform.position, -Vector3.up + new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)), Color.red, 1000000f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ThrowLine()
    {
        RaycastHit hit;
        for (int i = 0; i < 100; i++)
        {
            if (Physics.Raycast(transform.position, Vector3.right + new Vector3(0, Random.Range(-1f, 1f), Random.Range(-1f, 1f)), out hit, Mathf.Infinity))
            {
                Debug.Log(hit.point);
                Instantiate(gazon, hit.point, Quaternion.identity);
            }
        }


    }
}
