using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Baracuda.Monitoring;

public class move : MonoBehaviour
{
	// Start is called before the first frame update
	public Vector2 SPEED = new Vector2();
	// Use this for initialization

	// Update is called once per frame
	void Update()
	{
		// 移動処理
		Move();
	}

	// 移動関数
	void Move()
	{
		// 現在位置をPositionに代入
		float moveX = 0f;
		float moveY = 0f;
		Vector2 Position = transform.position;
		// 左キーを押し続けていたら
		if (Input.GetKey("a"))
		{
			// 代入したPositionに対して加算減算を行う
			SPEED.x -= 0.001f;
			if (SPEED.x < -0.05f)
			{
				SPEED.x = -0.05f;
			}
			if (SPEED.x > 0)
			{
				SPEED.x -= 0.004f;
			}
		}
		else if (Input.GetKey("d"))
		{ // 右キーを押し続けていたら
		  // 代入したPositionに対して加算減算を行う
			SPEED.x += 0.001f;
			if (SPEED.x > 0.05f)
			{
				SPEED.x = 0.05f;
			}
			if (SPEED.x < 0)
			{
				SPEED.x += 0.004f;
			}
		}
		else
		{
			if (SPEED.x > 0)
			{
				SPEED.x -= 0.001f;
				if (SPEED.x < 0)
				{
					SPEED.x = 0;
				}
			}
			else
			{
				SPEED.x += 0.001f;
				if (SPEED.x > 0)
				{
					SPEED.x = 0;
				}
			}
		}
		if (Input.GetKey("w"))
		{ // 上キーを押し続けていたら
		  // 代入したPositionに対して加算減算を行う
			SPEED.y += 0.001f;
			if (SPEED.y > 0.05f)
			{
				SPEED.y = 0.05f;
			}
			if (SPEED.y < 0)
			{
				SPEED.y += 0.004f;
			}
		}
		else if (Input.GetKey("s"))
		{ // 下キーを押し続けていたら
		  // 代入したPositionに対して加算減算を行う
			SPEED.y -= 0.001f;
			if (SPEED.y < -0.05f)
			{
				SPEED.y = -0.05f;
			}
			if (SPEED.y > 0)
			{
				SPEED.y -= 0.004f;
			}
		}
		else
		{
			if (SPEED.y > 0)
			{
				SPEED.y -= 0.001f;
				if (SPEED.y < 0)
				{
					SPEED.y = 0;
				}
			}
			else
			{
				SPEED.y += 0.001f;
				if (SPEED.y > 0)
				{
					SPEED.y = 0;
				}
			}
		}
		moveX += SPEED.x;
		moveY += SPEED.y;
		if (moveX != 0f && moveY != 0f)
		{
			//float a = Mathf.Sqrt(moveX * moveX + moveY * moveY);
			moveX /= 1.4f;
			moveY /= 1.4f;
		}
		Position.x += moveX;
		Position.y += moveY;
		// 現在の位置に加算減算を行ったPositionを代入する
		transform.position = Position;
	}
}
