using UnityEngine;

public class PlaneMoving : MonoBehaviour
{

    public Transform targetBox;
    public float speed = 1f;
    bool _goToBox = false;
    void Update()
    {
        transform.position += (targetBox.position - transform.position).normalized * speed * Time.deltaTime;
        if ((targetBox.position - transform.position).sqrMagnitude < 10f)
        {
            DisableChilds();
        }
        if ((targetBox.position - transform.position).sqrMagnitude < 1f)
        {
            Destroy(gameObject);
        }
    }

    public Transform panel;

    public void DisableChilds()
    {
        for (int i = 0; i < panel.childCount; i++)
        {
            if (panel.GetChild(i).gameObject.name == "planeexplosion")
            {
                panel.GetChild(i).gameObject.SetActive(true);
            }
        }
    }

}
