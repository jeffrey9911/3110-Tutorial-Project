using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class EditorManager : MonoBehaviour
{
    PlayerAction inputAction;

    public Camera mainCam;
    public Camera editorCamera;

    public GameObject prefab1;
    public GameObject prefab2;

    GameObject item;

    public bool editorMdoe = false;

    bool instantiated = false;

    Vector3 mousePos;

    Subject subject = new Subject();

    /*
    private void OnEnable()
    {
        inputAction.Enable();
    }

    private void OnDisable()
    {
        inputAction.Disable();
    }*/

    private void Start()
    {
        //inputAction = new PlayerAction();
        inputAction = PlayerInputController.controller.inputAction;


        inputAction.Editor.Enabled.performed += cntxt => SwitchCamera();
        inputAction.Editor.AddItem1.performed += cntxt => AddItem(1);
        inputAction.Editor.AddItem2.performed += cntxt => AddItem(2);
        inputAction.Editor.DropItem.performed += cntxt => Drop();

        mainCam.enabled = true;
        editorCamera.enabled = false;
    }
    
    private void SwitchCamera()
    {
        mainCam.enabled = !mainCam.enabled;
        editorCamera.enabled = !editorCamera.enabled;
    }

    private void AddItem(int itemID)
    {
        if(editorMdoe && !instantiated)
        {
            switch(itemID)
            {
                case 1:
                    item = Instantiate(prefab1);
                    SpikeBall spike1 = new SpikeBall(item, new GreenMat());
                    subject.AddObserver(spike1);
                    break;
                case 2:
                    item = Instantiate(prefab2);
                    SpikeBall spike2 = new SpikeBall(item, new YellowMat());
                    subject.AddObserver(spike2);
                    break;


                    default:
                    break;
            }
            subject.Notify();
            instantiated = true;
        }
    }

    private void Drop()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<SphereCollider>().enabled = true;

        instantiated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(mainCam.enabled == false && editorCamera.enabled == true)
        {
            editorMdoe = true;
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            editorMdoe = false;
            Time.timeScale = 1.0f;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if(instantiated)
        {
            mousePos = Mouse.current.position.ReadValue();
            mousePos = new Vector3(mousePos.x, mousePos.y, 10.0f);

            item.transform.position = editorCamera.ScreenToWorldPoint(mousePos);
        }
    }
}
