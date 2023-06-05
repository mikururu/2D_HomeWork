using UnityEngine;

public class ControlSystem : MonoBehaviour
{
	[Header("移動速度")]
	[Range(0,100)]
	public float moveSpeed = 3.5f;

	[Header("鋼體")]
	public Rigidbody2D rig;
	[Header("動畫控制器")]
	public Animator ani;
	[Header("跑步參數")]
	public string parRun = "開關走路";
	private void Awake()
	{
		
	}
	private void Start()
	{
		
	}
	private void Update()
	{
		Move();
	}

	private void Move()
	{
		float h = Input.GetAxis("Horizontal");
		rig.velocity = new Vector2(h, 0) * moveSpeed;

		ani.SetBool(parRun,h != 0);
	}
}

