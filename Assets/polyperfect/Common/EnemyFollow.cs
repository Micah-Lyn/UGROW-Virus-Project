using UnityEngine;
public class EnemyFollow : MonoBehaviour
{
    public Transform player;
    private Rigidbody rb;
    private UnityEngine.Vector3 movement;
    public float _speed = 4;
    //  [SerializeField]
    //private float _speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        //rb used to manipulate movement and rotation of the object
    }
    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x)* Mathf.Rad2Deg;
        rb.rotation = UnityEngine.Quaternion.Euler(0f, angle, 0f);
        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(UnityEngine.Vector3 direction) {
        rb.MovePosition(transform.position + (direction * _speed * Time.deltaTime));
    }
}