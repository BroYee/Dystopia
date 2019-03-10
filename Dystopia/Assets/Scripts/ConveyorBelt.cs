using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    [SerializeField] private float speed;

    private bool operating;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (operating)
        {
            Operate();
        }

    }

    private void Operate()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}

