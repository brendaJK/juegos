using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookForward : MonoBehaviour
{
    public Transform sighStart, sighEnd;
    private bool collision;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        collision = Physics2D.Linecast(sighStart.position, sighEnd.position, 1 << LayerMask.NameToLayer("Solid"));
        Debug.DrawLine(sighStart.position, sighEnd.position, Color.green);
        if (collision) {
            transform.localScale = new Vector3(transform.localScale.x == 1 ? -1 : 1, 1, 1);
        }
    }
}
