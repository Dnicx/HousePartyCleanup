using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    string HORIZONTAL_AXIS  = "Horizontal";
    string VERTICAL_AXIS    = "Vertical";
    string ACTION_BUTTON    = "Fire1";

    public Vector2 speed = new Vector2( 10, 10 );
    public PlayerItem[] item = new PlayerItem[5];

    private Vector2 _direction;
    private GameObject _objectInFocus;
    private int currentItem;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        ProcessMovement();

        ProcessInteraction();

        ProcessItemSelect();

    }

    //  Get input and calculate new position of player
    public void ProcessMovement()
    {
        
        _direction.x = Input.GetAxisRaw( HORIZONTAL_AXIS );
        _direction.y = Input.GetAxisRaw( VERTICAL_AXIS );

        Vector2 Offset = _direction.normalized * speed * Time.deltaTime;

        transform.position = new Vector3( transform.position.x + Offset.x, transform.position.y + Offset.y , transform.position.z ) ;
        
        _UpdateMoveAnimation();

    }

    //  poll input key and check if correct item is selected
    public void ProcessInteraction() 
    {
        bool doInteract = Input.GetButton( ACTION_BUTTON );

        if ( _PassInteractionCondition() )
        {
            if ( _objectInFocus != null ) 
            {
                
                DirtyObject objectScript = _objectInFocus.GetComponent<DirtyObject>();

                // objectScript.Interact(  )

            }

            //do some interaction with interactable
            _UpdateInteractAnimation(); 

        }

    }

    //  poll inputkey for when player select item
    public void ProcessItemSelect()
    {


        
    }

    //  TODO: Implement this fucntion when there is an animation to work with
    private void _UpdateMoveAnimation() {
        return;
    }

    //  TODO: Implement this fucntion when there is an animation to work with
    private void _UpdateInteractAnimation() {
        return;
    }

    //  TODO:  Check in currently equip item meets requirement
    private bool _PassInteractionCondition() {

        return false;
    }

}
