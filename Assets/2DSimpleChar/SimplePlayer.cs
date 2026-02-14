using UnityEngine;

public class SimplePlayer : MonoBehaviour //library สำหรับช่วง gameplay
{
    private Rigidbody2D rigid; // component rigidbody2D
    private Animator anim; // component animator

    [Header("Ground And Wall Check")]
    [SerializeField] private float groundDistCheck = 1f; // ระยะ sensor ตรวจหาพื้น
    [SerializeField] private float wallDistCheck = 1f; // ระยะ sensor ตรวจหาผนัง
    [SerializeField] private LayerMask groundLayer; // sensor เจอเฉพาะ ground layer
    public bool isGrounded = false; // เจอพื้น ?
    public bool isWalled = false; // เจอผนัง ?

    private void Awake() // Awake() ทำก่อน Start() 
    {
        rigid = GetComponent<Rigidbody2D>(); // ดึงจากตัวมันเอง
        anim = GetComponentInChildren<Animator>(); // InChildren เพราะดึงจากลูมัน
    }
    private void Update() // method ที่รันทุก frame
    {
        JumpState(); // ดูสถานะการกระโดด >> takeoff, landing, wallSlide, etc
        Jump(); // สั่งให้กระโดด
        WallSlide(); //  สั่งให้ wallSlide
        InputVal(); // ค่า input จาก player
        Move(); // สั้งให้เคลื่อนที่แนวนอน ทั้งตอนอยู่บนพื้นและกลางอากาศ
        Flip(); // หันซ้าย/ขวา เวลา wallJump ให้โดดทิศตรงข้ามกำแพง
        GroundAndWallCheck(); // ตรวจพื้นกับผนัง
        Animation(); // สั่งให้ play Animation
    }
    private void JumpState()
    {

    }
    private void Jump()
    {

    }
    private void WallSlide()
    {

    }
    private void InputVal()
    {

    }
    private void Move()
    {

    }
    private void Flip()
    {

    }
    private void GroundAndWallCheck()
    {
        // Raycast(เริ่มจุดไหน, ทิศไหน, ระยะทาง, layerMask ที่จะตรวจ)
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundDistCheck, groundLayer); // sensor พื้น
        isWalled = Physics2D.Raycast(transform.position, transform.right, wallDistCheck, groundLayer); // sensor ผนัง
    }
    private void OnDrawGizmos() // method ที่ unity รู้จัก ไว้แสดงผล sensor พื้นและผนัง
    {
        Gizmos.color = Color.blue;  // สีของ sensor
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * groundDistCheck); // UI แสดง sensor พื้น
        Gizmos.color = Color.red;  // สีของ sensor
        Gizmos.DrawLine(transform.position, transform.position + transform.right * wallDistCheck); // UI แสดง sensor ผนัง
    }
    private void Animation()
    {

    }
}
