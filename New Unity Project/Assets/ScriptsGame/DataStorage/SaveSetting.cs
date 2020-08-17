using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveSetting
{
	public string Name;
	public string DataPath;
	public bool BAutoSave;
	public SaveType SaveType;
	public bool BAysn;

	public SaveSetting(string name, string dataPath = "", bool autoSave = true, SaveType saveType = SaveType.Json, bool bAysn = false)
	{
		//todo
		Name = name;
		DataPath = Application.streamingAssetsPath;
		BAutoSave = autoSave;
		SaveType = saveType;
		BAysn = bAysn;
	}
}

public enum SaveType
{
	Json, XML, Sqlite, Stream, File
}
