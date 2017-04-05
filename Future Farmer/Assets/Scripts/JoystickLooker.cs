using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.EventSystems;

public class JoystickLooker : MonoBehaviour
{

    // internal private variables
    private Quaternion m_CharacterTargetRot;
    private Quaternion m_CameraTargetRot;
    private Transform character;
    private Transform cameraTransform;

    //reference to joystick
    public GameObject m_joystick;

    void Start()
    {
        // get a reference to the character's transform (which this script should be attached to)
        character = gameObject.transform;

        // get a reference to the main camera's transform
        cameraTransform = Camera.main.transform;

        // get the location rotation of the character and the camera
        m_CharacterTargetRot = character.localRotation;
        m_CameraTargetRot = cameraTransform.localRotation;

        //tell the game to watch the joystick
        EventSystem.current.SetSelectedGameObject(m_joystick, null);
    }

    void Update()
    {
        //Debug.Log(CrossPlatformInputManager.GetAxis("V"));
        //Debug.Log(CrossPlatformInputManager.GetAxis("H"));
        // rotate stuff based on the mouse
        LookRotation();
    }

    public void LookRotation()
    {
        ////get the y and x rotation based on the Joystick
        float yRot = CrossPlatformInputManager.GetAxis("Horizontal");
        //Debug.Log(CrossPlatformInputManager.GetAxis("Vertical"));
        float xRot = CrossPlatformInputManager.GetAxis("Vertical");
        //Debug.Log(CrossPlatformInputManager.GetAxis("Horizontal"));

        // calculate the rotation
        m_CharacterTargetRot *= Quaternion.Euler(0f, 4*yRot, 0f);
        m_CameraTargetRot *= Quaternion.Euler(-xRot*4, 0f, 0f);
        
        //// update the character and camera based on calculations
        //if (smooth) // if smooth, then slerp over time
        //{
        //    character.localRotation = Quaternion.Slerp(character.localRotation, m_CharacterTargetRot,
        //                                                smoothTime * Time.deltaTime);
        //    cameraTransform.localRotation = Quaternion.Slerp(cameraTransform.localRotation, m_CameraTargetRot,
        //                                             smoothTime * Time.deltaTime);
        //}
        //else // not smooth, so just jump
        //{
            character.localRotation = m_CharacterTargetRot;
            cameraTransform.localRotation = m_CameraTargetRot;
        //}
    }
}
