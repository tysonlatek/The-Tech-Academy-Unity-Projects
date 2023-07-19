using System.Collections;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target; //The object to rotate around
    public int speed; //The speed of rotation

    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("RotateAround target not specified. Defaulting to parent GameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //RotateAround takes three arguments, first is the Vector to rotate around
        //Second is a vector that axis to rotate around
        //Third is the degrees to rotate, in this case the speed per second
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}