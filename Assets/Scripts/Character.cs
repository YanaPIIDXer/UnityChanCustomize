using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// キャラクタ
/// </summary>
public class Character : MonoBehaviour
{
	/// <summary>
	/// アニメータ
	/// </summary>
	private Animator Anim = null;

	/// <summary>
	/// 左足トランスフォーム
	/// </summary>
	[SerializeField]
	private Transform LeftLegTransform = null;

	/// <summary>
	/// 右足トランスフォーム
	/// </summary>
	[SerializeField]
	private Transform RightLegTransform = null;

	private void Awake()
	{
		Anim = GetComponent<Animator>();
		Anim.Play("WAIT00");

		// とりあえず足長。
		SetLegScale(2.5f);
	}

	/// <summary>
	/// ジャンプ
	/// </summary>
	public void Jump()
	{
		Anim.Play("JUMP00");
	}

	/// <summary>
	/// 足のスケールを設定。
	/// </summary>
	/// <param name="Scale"></param>
	public void SetLegScale(float Scale)
	{
		LeftLegTransform.localScale = new Vector3(Scale, 1.0f, 1.0f);
		RightLegTransform.localScale = new Vector3(Scale, 1.0f, 1.0f);
	}
}
