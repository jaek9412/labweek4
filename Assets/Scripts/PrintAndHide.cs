using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int count;
    private int rand;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        rand = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Red") && count == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.CompareTag("Blue") && count == rand)
        {
            rend.enabled = false;
        }
        Debug.Log(gameObject.name + ": " + count);
        count++;
    }
}
