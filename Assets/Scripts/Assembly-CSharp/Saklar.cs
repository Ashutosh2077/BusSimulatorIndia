using UnityEngine;

public class Saklar : MonoBehaviour
{
	[Range(0.001f, 600f)]
	public float timer;

	public GameObject[] saklars;

	private float timeToSwitch;

	private void Update()
	{
	}
}
