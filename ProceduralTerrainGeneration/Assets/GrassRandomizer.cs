using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassRandomizer : MonoBehaviour
{
    public List<Texture2D> grassTypes = new List<Texture2D>();
    int grassIndex;

    void Awake()
    {
        grassIndex = Random.Range(0, grassTypes.Count);
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<Renderer>().material.mainTexture = grassTypes[grassIndex];
        }
    }
}
