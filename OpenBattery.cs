using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBattery : MonoBehaviour
{

    [SerializeField] float moveSpeed = .05f;
    [SerializeField] GameObject top;
    [SerializeField] GameObject board;
    [SerializeField] GameObject cells;
    [SerializeField] GameObject bottom;

    public bool isOpen = false;
    public ExtendCells extendCells;

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    
    {
        if (isOpen == false)
        {
            OpenBatteryCase();
        }

        else if (isOpen && extendCells.isExtended == false)
        {
            CloseBatteryCase();
        }
    }

    private void CloseBatteryCase()
    {
        Vector3 topXMovement = new Vector3(-0.99f, 0f, 0f);
        Vector3 boardXMovement = new Vector3(-0.68f, 0f, 0f);
        Vector3 bottomXMovement = new Vector3(0.79f, 0f, 0f);

        top.transform.Translate(topXMovement);
        board.transform.Translate(boardXMovement);
        bottom.transform.Translate(bottomXMovement);
        isOpen = false;
    }

    private void OpenBatteryCase()
    {
        Debug.Log("Close");
        Vector3 topXMovement = new Vector3(0.99f, 0f, 0f);
        Vector3 boardXMovement = new Vector3(0.68f, 0f, 0f);
        Vector3 bottomXMovement = new Vector3(-0.79f, 0f, 0f);

        top.transform.Translate(topXMovement);
        board.transform.Translate(boardXMovement);
        bottom.transform.Translate(bottomXMovement);
        isOpen = true;
    }
}   
