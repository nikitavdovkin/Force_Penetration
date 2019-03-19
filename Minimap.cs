using UnityEngine;

public class Minimap : MonoBehaviour
{

    public Transform pltr;
    public Camera cam;

    private void LateUpdate()
    {
        CamTr();
    }

    public void CamTr()
    {
        Vector3 newpos = pltr.position;
        newpos.y = transform.position.y;
        transform.position = newpos;
        if (Input.GetKey(KeyCode.Q) && cam.orthographicSize > 20.0f)
        {
            cam.orthographicSize -= 5.0f;
        }
        if (Input.GetKey(KeyCode.E) && cam.orthographicSize < 100.0f)
        {
            cam.orthographicSize  += 5.0f;
        }
        transform.rotation = Quaternion.Euler(90, pltr.eulerAngles.y, 0);
    }
}
