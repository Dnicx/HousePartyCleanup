using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{

    public int size = 10;
    public float pickupTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pickup()
    {

        Destroy( this.gameObject );

    }

    public int GetSize()
    {
        return size;
    }

}
