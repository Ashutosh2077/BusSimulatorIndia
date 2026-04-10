using UnityEngine;
using UnityEngine.UI;

public class DriverController : MonoBehaviour
{
	private enum DriverState
	{
		Assigned = 0,
		Jump = 1,
		Dance = 2,
		Bench = 3,
		Selfie = 4,
		Drive = 5,
		Idle = 6,
		Walk = 7,
		Run = 8
	}

	public Button[] btnStates;

	public Button[] btnDrivers;

	public Button[] btnAnimationSpeed;

	public Animator[] animatorDrivers;

	public Transform trParentCamera;

	public float speed;

	public float animationSpeedMultiplier;

	public float rotateSpeed;

	private Animator activeAnimator;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void AddBtnDriverListener()
	{
	}

	private void SetDriver(int index)
	{
	}

	private void AddBtnStateListener()
	{
	}

	private void SetAnimationState(string strState)
	{
	}

	private void AddBtnAnimationSpeedListener()
	{
	}

	private void SetAnimationSpeed(float speed)
	{
	}
}
