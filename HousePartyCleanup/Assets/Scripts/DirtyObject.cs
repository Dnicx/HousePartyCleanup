using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyObject : MonoBehaviour
{

    public enum DirtyObjectType { Floor, Wall, Dishes, Trash, Broken };

    public DirtyObjectType objectType   = DirtyObjectType.Floor;
    public float dirtiness  = 10.0f;
    public float dirtinessToCleanPercentage = 25.0f;
    public float currentdirtiness;
    private float _percentDirtiness;

        // Start is called before the first frame update
    void Start()
    {
        currentdirtiness = dirtiness;
    }

    // Update is called once per frame
    void Update()
    {
        float _percentDirtiness = ( dirtiness - currentdirtiness ) / dirtiness;

        if ( _percentDirtiness < dirtinessToCleanPercentage )
        {
            Destroy( this.gameObject );
        }
    }

    public void Interact( float cleanValue )
    {

        this.currentdirtiness -= cleanValue;
        
    }

}
