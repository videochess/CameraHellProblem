using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public GameObject playerMesh;
    public float horizontal = 0;
    public float vertical = 0;
    public Vector3 direction = new Vector3();
    public float camAngle = 0;

    public float speed = 6f;
    public float normSpeed = 6f;
    public float fastSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        direction = new Vector3(horizontal, 0f, vertical).normalized;
        camAngle = Camera.main.transform.eulerAngles.y;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camAngle;
            playerMesh.transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir * speed * Time.deltaTime);

            Debug.DrawRay(transform.position, moveDir * 5, Color.yellow, .01f); // draw the debug ray
        }

        DebugLoop(); // just cordoning off debug functions into their own zone
    }

    private void DebugLoop()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = fastSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = normSpeed;
        }
    }

    private void OnDrawGizmos()
    {
        // nothing here rn
    }
}
