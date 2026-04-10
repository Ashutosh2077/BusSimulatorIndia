using System;
using UnityEngine;

namespace BUSSID
{
	[AddComponentMenu(null)]
	public class PassengerAIMovement : MonoBehaviour
	{
		public enum State
		{
			ExitBus = 0,
			TowardLandmark = 1,
			SearchLookArea = 2,
			LookAround = 3,
			BackToBus = 4
		}

		public State state;

		[Header("Movement")]
		[SerializeField]
		private float maxVelocity;

		[SerializeField]
		private float maxAcceleration;

		[SerializeField]
		private float turnSpeed;

		[SerializeField]
		private float timeToTarget;

		[SerializeField]
		private float slowRadius;

		[SerializeField]
		private float climbStairsVelocity;

		[Header("Ground Check")]
		[SerializeField]
		private LayerMask groundCheckMask;

		[SerializeField]
		private float groundFollowDistance;

		[Tooltip("The max duration of the AI to walk in the air before it will be forced to the ground")]
		[SerializeField]
		private float maxDurationToGrounded;

		[SerializeField]
		[ReadOnly]
		private float notGroundedDuration;

		[SerializeField]
		[ReadOnly]
		private bool isGrounded;

		[Header("Stairs Detection")]
		[Tooltip("Maximum height of the stairs which can be climbed")]
		[SerializeField]
		private float maxStairsHeight;

		[SerializeField]
		private float minStairsHeight;

		[Tooltip("How far is the distance of the start Top raycast position from the AI body")]
		[SerializeField]
		private float stairsTopRaycastFrontDistance;

		[Tooltip("The start Y position of the Top raycast")]
		[SerializeField]
		private float stairsTopRaycastHeight;

		[Tooltip("To prevent the ground get raycasted, need to be some clearance")]
		[SerializeField]
		private float stairsRaycastGroundDistance;

		[SerializeField]
		[ReadOnly]
		private bool isHitStair;

		[Header("Collision Detection")]
		[SerializeField]
		private float wallAvoidDistance;

		[SerializeField]
		private float mainRayLength;

		[SerializeField]
		private float sideRayLength;

		[SerializeField]
		private float sideRayAngle;

		[SerializeField]
		private float slopeLimit;

		[SerializeField]
		private LayerMask collisionDetectionMask;

		private float colliderRadius;

		[Header("Follow Path")]
		[SerializeField]
		private float stopRadius;

		[SerializeField]
		private float pathOffset;

		[SerializeField]
		private float pathDirection;

		[Header("--DEBUG--")]
		[SerializeField]
		private bool debugDrawRay;

		[SerializeField]
		[ReadOnly]
		private float debugVelocity;

		private Rigidbody rigid;

		private CapsuleCollider capsuleCollider;

		private CharacterVisual visual;

		private PassengerAIPath path;

		private Vector3 lookAroundDir;

		private bool isWalking;

		public Action<PassengerAIMovement> onTargetReached;

		private Vector3 StairsRaycastTop => default(Vector3);

		private Vector3 StairsRaycastBottom => default(Vector3);

		private float StairsRaycastTopLength => 0f;

		private float StairsRaycastBottomLength => 0f;

		private Vector3 RotationAsVector => default(Vector3);

		private Vector3 ColliderPosition => default(Vector3);

		private Vector3 Velocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void MoveToPath(Vector3[] pos)
		{
		}

		public void LookAround(Vector3 direction)
		{
		}

		private void LookAround()
		{
		}

		private void MoveToPath()
		{
		}

		private void ToggleEnable(bool isEnable)
		{
		}

		private void CheckGrounded()
		{
		}

		private void CheckStairs()
		{
		}

		private void Idle(bool forceIdle = false)
		{
		}

		private void Move(Vector3 linearAcceleration)
		{
		}

		private Vector3 Seek(Vector3 targetPosition)
		{
			return default(Vector3);
		}

		private Vector3 Arrive(Vector3 targetPosition)
		{
			return default(Vector3);
		}

		private void LookIntoDirection(Vector3 direction)
		{
		}

		private Vector3 FollowPath(PassengerAIPath path)
		{
			return default(Vector3);
		}

		private bool IsEndOfPath(PassengerAIPath path, float param, out Vector3 finalDestination)
		{
			finalDestination = default(Vector3);
			return false;
		}

		private Vector3 GetSteering()
		{
			return default(Vector3);
		}

		private Vector3 GetSteering(Vector3 facingDir)
		{
			return default(Vector3);
		}

		private bool FindObstacle(Vector3 facingDir, out RaycastHit firstHit)
		{
			firstHit = default(RaycastHit);
			return false;
		}

		private bool CastRays(Vector3[] dirs, float[] dist, out RaycastHit firstHit, int layerMask)
		{
			firstHit = default(RaycastHit);
			return false;
		}

		private bool GenericCast(Vector3 direction, out RaycastHit hit, int layerMask, float distance = float.PositiveInfinity)
		{
			hit = default(RaycastHit);
			return false;
		}
	}
}
