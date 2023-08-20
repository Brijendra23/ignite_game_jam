using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speedIncrease = 0.02f;
    [SerializeField] private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += speedIncrease * Time.deltaTime;
        transform.Translate(-Vector3.forward * Time.deltaTime*speed,Space.World);
    }
}
