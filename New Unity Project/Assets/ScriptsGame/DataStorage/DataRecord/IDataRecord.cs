using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface IDataRecord
{
	bool isDirty { get; }
	void SetDirty(UnityEvent callBack);
	void SetDirty(bool b, UnityEvent callBack);
}