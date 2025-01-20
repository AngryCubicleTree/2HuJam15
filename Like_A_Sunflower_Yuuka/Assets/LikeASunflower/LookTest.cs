using UnityEngine;

public class LookTest : MonoBehaviour
{
    [SerializeField] float fadeDistance;


    // Update is called once per frame
    void Update()
    {


        transform.rotation = Quaternion.Euler(0,Camera.main.transform.rotation.eulerAngles.y,0);
    }
}
