using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendCells : MonoBehaviour
{
    [SerializeField] float xMove = -.305f;
    [SerializeField] float moveSpeed;
    //BoxCollider cellCollider;
    public OpenBattery openBattery;
    public bool isExtended = false;


    // Start is called before the first frame update
    void Start()
    {
        //cellCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        if (isExtended == false && openBattery.isOpen == true)
        {
            Vector3 batteryExtend = new Vector3(0, -xMove, 0f);
            transform.Translate(batteryExtend);
            isExtended = true;  
        }

        else if (isExtended == true && openBattery.isOpen == true)
        {
            Vector3 batteryExtend = new Vector3(0, xMove, 0f);
            transform.Translate(batteryExtend);
            isExtended = false;
        }
    }
}
