using System;
using BusSimulator.CustomEVP;
using EVP;
using UnityEngine;

public class BUSSIDEVPCarController : CarController
{
	private VehicleController vehicle;

	private BUSSIDRigidbodyPause rigidbodyPause;

	private Rigidbody body;

	public override float throttleInput
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override float brakeInput
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override float steerInput
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override float handbrakeInput
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public override Rigidbody GetBody()
	{
		return null;
	}

	public override float GetMaxBrakeForce()
	{
		return 0f;
	}

	public override float GetSteerAngleDelta()
	{
		return 0f;
	}

	public override void TeleportTo(Vector3 pos, Quaternion rot)
	{
	}

	public override void SetPause(bool isPause)
	{
	}

	public override void SetVelocity(Vector3 vel)
	{
	}

	public override float SpeedMPS()
	{
		return 0f;
	}

	public override float SpeedKMH()
	{
		return 0f;
	}

	public override void SetExternalDriveForceCompute(Func<float, float, bool, float, float> drive, Func<float, float, float, float> brake)
	{
	}

	public override void SetRollingResistance(float rollingResistance)
	{
	}

	public override void SetMaxSpeedForward(float speedKMH)
	{
	}

	public override void SetMaxSpeedReverse(float speedKMH)
	{
	}

	public override void SetDriveForce(float force)
	{
	}

	public override void SetMaxSpeed(float speedKMH)
	{
	}

	public override void SetGearboxRatio(float ratio)
	{
	}

	public override void ResetVehicle()
	{
	}

	public override int GetWheelsCount()
	{
		return 0;
	}

	public override Transform GetWheelVisualTransform(int wheelIndex)
	{
		return null;
	}

	public override Transform GetWheelVisualTransform(string wheelName)
	{
		return null;
	}

	public override Transform GetWheelTransform(int wheelIndex)
	{
		return null;
	}

	public override bool GetWheelGroundHit(int wheelIndex, out WheelHit hit)
	{
		hit = default(WheelHit);
		return false;
	}

	public override Vector3 GetWheelLowerPoint(int wheelIndex)
	{
		return default(Vector3);
	}

	public override bool IsPaused()
	{
		return false;
	}

	public override void SetAsNetworkOpponent()
	{
	}

	public override void SetVisible(bool visible)
	{
	}
}
