using UnityEngine;

public class Move : MonoBehaviour
{
    CharacterController mainobj;
    public float speed = 60.0f;
    Vector3 moveDirection = Vector3.zero;
    void Start()
    {
        mainobj = this.GetComponent<CharacterController>();
    }
    void Update()
    {
        if (mainobj != null)
        {
            float AD = Input.GetAxis("Horizontal");
            float WS = Input.GetAxis("Vertical");
            moveDirection = new Vector3(AD, 0, WS);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            mainobj.Move(moveDirection * Time.deltaTime);
        }
    }
}
