// Generated by gencs from turtlesim/Pose.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;


namespace SIGVerse.RosBridge 
{
	namespace turtlesim 
	{
		[System.Serializable]
		public class Pose : RosMessage
		{
			public float x;
			public float y;
			public float theta;
			public float linear_velocity;
			public float angular_velocity;


			public Pose()
			{
				this.x = 0.0f;
				this.y = 0.0f;
				this.theta = 0.0f;
				this.linear_velocity = 0.0f;
				this.angular_velocity = 0.0f;
			}

			public Pose(float x, float y, float theta, float linear_velocity, float angular_velocity)
			{
				this.x = x;
				this.y = y;
				this.theta = theta;
				this.linear_velocity = linear_velocity;
				this.angular_velocity = angular_velocity;
			}

			new public static string GetMessageType()
			{
				return "turtlesim/Pose";
			}

			new public static string GetMD5Hash()
			{
				return "863b248d5016ca62ea2e895ae5265cf9";
			}
		} // class Pose
	} // namespace turtlesim
} // namespace SIGVerse.ROSBridge
