using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataRecorder : IDataRecord
{
	protected bool m_IsDirty;
	public bool isDirty
	{
		get
		{
			return m_IsDirty;
		}
	}

	public void SetDirty(UnityEvent callBack)
	{
		m_IsDirty = false;
		callBack.Invoke();
	}

	public void SetDirty(bool b, UnityEvent callBack)
	{
		m_IsDirty = b;
		callBack.Invoke();
	}
}
