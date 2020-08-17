using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseData : DataRecorder, System.ICloneable
{
	public virtual void OnDataLoadStart()
	{

	}

	public virtual void OnDataLoadFinish()
	{

	}

	public virtual object Clone()
	{
		return null;
	}
}
